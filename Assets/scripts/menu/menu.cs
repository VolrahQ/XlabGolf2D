using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI; 

public class menu : MonoBehaviour
{
    
    public Button startButton;
    public Button settingsButton;
    public Button quitButton;

    
    public string gameSceneName = "inGame";

    void Start()
    {
        
        startButton.onClick.AddListener(OnStartButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    
    void OnStartButtonClicked()
    {
        
        SceneManager.LoadScene(gameSceneName);
    }

    
    void OnSettingsButtonClicked()
    {
       
        Debug.Log("���������");
    }

    
    void OnQuitButtonClicked()
    {
    
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
