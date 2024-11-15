using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI; 

public class menu : MonoBehaviour
{
    
    public Button startButton;
    public Button settingsButton;
    public Button quitButton;

    
    public string gameSceneName = "inGame";

    private void Start()
    {
        
        startButton.onClick.AddListener(OnStartButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    
    public void OnStartButtonClicked()
    {
        
        SceneManager.LoadScene(gameSceneName);
    }

    
    public void OnSettingsButtonClicked()
    {
       
        Debug.Log("���������");
    }

    
    public void OnQuitButtonClicked()
    {
            Application.Quit();
    }
}
