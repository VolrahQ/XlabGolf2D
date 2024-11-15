using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public AudioSource _audiosSource;
    public int ClickToTable;
    public bool TableActive = false;
    private Image _image;
    
    public void MainTableClick()
    {
        MoneyManager.Instance.AddFunds(DataManager.taskLevel*5);
        if (TableActive == true)
        {
        ClickToTable++;
        CheckClickToTable(ClickToTable, TableActive);
        }
    }

    private void CheckClickToTable(int item, bool i)
    {
        if (item == 10 && i)
        {
            MoneyManager.Instance.AddFunds(100 * DataManager.tableLevel);
            TableActive = false;
            ClickToTable = 0;
        }
    }
    public void ActivateDelegateTable()
    {
        TableActive = true;
    }

    private void Update()
    {
        if (DataManager.money <= 100)
        {
            _audiosSource.Play();
            DataManager.money = 200;
            DataManager.tableLevel = 1;
            DataManager.taskLevel = 1;
            DataManager.Save();
            SceneManager.LoadScene("Menu");
        }
        
        if (TableActive)
        {
            ShowImage(); 
        }
        else
        {
            HideImage(); 
        }

    }
    public Image targetImage;

   
    private bool isVisible = true;

    
    public bool someCondition = false;

    
    public void ShowImage()
    {
        if (targetImage != null)
        {
            targetImage.enabled = true;
            isVisible = true;
        }
    }

    
    public void HideImage()
    {
        if (targetImage != null)
        {
            targetImage.enabled = false;
            isVisible = false;
        }
    }

    
    public void ToggleImage()
    {
        if (targetImage != null)
        {
            isVisible = !isVisible;
            targetImage.enabled = isVisible;
        }
    }
}
