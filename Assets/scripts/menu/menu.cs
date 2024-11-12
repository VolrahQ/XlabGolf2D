using UnityEngine;
using UnityEngine.SceneManagement;  // Для загрузки сцен
using UnityEngine.UI;  // Для работы с UI

public class menu : MonoBehaviour
{
    // Ссылки на кнопки
    public Button startButton;
    public Button settingsButton;
    public Button quitButton;

    // Имя сцены, на которую нужно перейти (измените на ваше имя сцены с игрой)
    public string gameSceneName = "inGame";

    void Start()
    {
        // Устанавливаем функции для кнопок
        startButton.onClick.AddListener(OnStartButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    // Функция для начала игры
    void OnStartButtonClicked()
    {
        // Загружаем сцену с игрой
        SceneManager.LoadScene(gameSceneName);
    }

    // Функция для перехода в настройки
    void OnSettingsButtonClicked()
    {
        // Здесь можно загрузить сцену настроек (если она есть)
        // Например:
        // SceneManager.LoadScene("SettingsScene");
        Debug.Log("Настройки");
    }

    // Функция для выхода из игры
    void OnQuitButtonClicked()
    {
        // Если игра в редакторе Unity, то она просто остановится
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
