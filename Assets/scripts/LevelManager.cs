using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int ClickToTable;
    public bool TableActive = false;
    
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
    }
}
