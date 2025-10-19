using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;           // ТУТА ВСЕ КАМЕРЫ 
    public int cameraIndex;            // ИНДЕКСЫ КАМЕР ОТ 0 (не перепутай)
    
    private void Start()
    {
        
        SwitchToCamera(0);
    }
    
    // по индексу меняет камеры
    public void SwitchToCamera(int index)
    {
        // ПроверОчка
        if (index < 0 || index >= cameras.Length)
        {
            return;
        }
        
        //Выключи его нахуй все камеры
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i] != null)
            {
                cameras[i].enabled = false;
            }
        }
        
        // Включи его нахуй
        if (cameras[index] != null)
        {
            cameras[index].enabled = true;
        }
    }
    
    // Метод для кнопОки
    public void SwitchToMyCamera()
    {
        SwitchToCamera(cameraIndex);
    }
}
