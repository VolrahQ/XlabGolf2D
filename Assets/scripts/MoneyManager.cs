using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public void AddMoney(int item)
    {
       DataManager.money += item;
       DataManager.Save();
    }
    public void RemoveMoney(int item)
    {
        DataManager.money -= item;
        DataManager.Save();
    }

}