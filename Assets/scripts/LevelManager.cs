using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int ClickToTable;
    public bool TableActive = false;
    private Image _image;
    
    public void MainTableClick()
    {
        MoneyManager.Instance.AddFunds(DataManager.taskLevel*2);
        //MoneyManager.Instance.TrySpendMoney(DataManager.tableLevel / 2);
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
            DataManager.money = 200;
            DataManager.tableLevel = 1;
            DataManager.taskLevel = 1;
            DataManager.Save();
            SceneManager.LoadScene("Menu");
        }
        // Проверяем условие
        if (TableActive)
        {
            ShowImage(); // Включить изображение
        }
        else
        {
            HideImage(); // Выключить изображение
        }

    }
    public Image targetImage;

    // Переменная для хранения текущего состояния (включено/выключено)
    private bool isVisible = true;

    // Пример условия (можно заменить на своё)
    public bool someCondition = false;

    // Метод для включения изображения
    public void ShowImage()
    {
        if (targetImage != null)
        {
            targetImage.enabled = true;
            isVisible = true;
        }
    }

    // Метод для отключения изображения
    public void HideImage()
    {
        if (targetImage != null)
        {
            targetImage.enabled = false;
            isVisible = false;
        }
    }

    // Метод для переключения состояния изображения
    public void ToggleImage()
    {
        if (targetImage != null)
        {
            isVisible = !isVisible;
            targetImage.enabled = isVisible;
        }
    }
}
