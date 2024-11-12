using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class ListSpawner : MonoBehaviour
{
    private int TaskPrice;
    private bool Task = false;
    private int TaskModifer;
    public MoneyManager moneyManager;
    public GameObject list;

    private void TaskPriceSwitch()
    {
        switch (DataManager.taskLevel)
        {
            case 1: TaskPrice = 5; break;
            case 2: TaskPrice = 10; break;
            case 3: TaskPrice = 20; break;
            case 4: TaskPrice = 30; break;
        }
    }
    private void TskSwitch()
    {
        switch (DataManager.tableLevel)
        {
            case 1: TaskModifer = 5; break;
            case 2: TaskModifer = 10; break;
            case 3: TaskModifer = 20; break;
            case 4: TaskModifer = 30; break;
        }
    }
   public void ListSpawn()
    {
        if (Task == false)
        {
            Task = true;
            TaskPriceSwitch();
            if (TaskPrice > DataManager.money)
            {
                moneyManager.RemoveMoney(TaskPrice);
            }
        }
    }
    public void ListSell()
    {
        if (Task)
        {
            if (TaskPrice >= 0)
            {
                moneyManager.AddMoney(TaskPrice);
            }
            Task = false;
        }
    }
    public void ListTask()
    {
        
    }
    
}
    
