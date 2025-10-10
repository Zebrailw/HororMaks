using UnityEngine;
using UnityEngine.UI;

public class SimpleCameraSwitcher : MonoBehaviour
{
    [Header("Camera List")]
    public Camera[] cameras;
    
    [Header("Display")]
    public RawImage displayImage;
    public RenderTexture displayTexture;
    
    [Header("Button Settings")]
    public int cameraIndex = 0;
    
    private void Start()
    {
        // Отключаем все камеры кроме первой
        for (int i = 0; i < cameras.Length; i++)
        {
            if (cameras[i] != null)
            {
                cameras[i].enabled = false;
            }
        }
        
        // Включаем первую камеру
        if (cameras.Length > 0 && cameras[0] != null)
        {
            cameras[0].enabled = true;
            cameras[0].targetTexture = displayTexture;
        }
    }
    
    public void SwitchToCamera()
    {
        // Отключаем все камеры
        foreach (Camera cam in cameras)
        {
            if (cam != null)
            {
                cam.enabled = false;
            }
        }
        
        // Включаем нужную камеру
        if (cameraIndex < cameras.Length && cameras[cameraIndex] != null)
        {
            cameras[cameraIndex].enabled = true;
            cameras[cameraIndex].targetTexture = displayTexture;
        }
    }
}
