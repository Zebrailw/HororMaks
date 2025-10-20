using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("UI References")]
    public Button exitButton;          // Кнопка выхода из игры
    public Button settingsButton;      // Кнопка открытия настроек
    public GameObject settingsPanel;   // Панель настроек
    
    [Header("Settings Panel")]
    public Button closeSettingsButton; // Кнопка закрытия настроек
    
    private void Start()
    {
        SetupButtons();
    }
    
    private void SetupButtons()
    {
        // Настройка кнопки выхода
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
        
        // Настройка кнопки настроек
        if (settingsButton != null)
        {
            settingsButton.onClick.AddListener(OpenSettings);
        }
        
        // Настройка кнопки закрытия настроек
        if (closeSettingsButton != null)
        {
            closeSettingsButton.onClick.AddListener(CloseSettings);
        }
        
        // Скрываем панель настроек при старте
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(false);
        }
    }
    
    // Метод для выхода из игры
    public void ExitGame()
    {
        Debug.Log("Выход из игры...");
        
        #if UNITY_EDITOR
            // Если в редакторе - останавливаем воспроизведение
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // Если в билде - закрываем приложение
            Application.Quit();
        #endif
    }
    
    // Метод для открытия панели настроек
    public void OpenSettings()
    {
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(true);
            Debug.Log("Открыты настройки");
        }
    }
    
    // Метод для закрытия панели настроек
    public void CloseSettings()
    {
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(false);
            Debug.Log("Настройки закрыты");
        }
    }
    
    // Метод для перезапуска игры
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Игра перезапущена");
    }
    
    // Метод для возврата в главное меню
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Замените на название вашей сцены меню
        Debug.Log("Возврат в главное меню");
    }
}
