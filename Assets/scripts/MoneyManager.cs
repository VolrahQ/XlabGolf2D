using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance { get; private set; }


    // Событие для обновления UI
    public delegate void OnMoneyChanged(int currentMoney);
    public event OnMoneyChanged MoneyChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddMoney(int amount)
    {
        if (amount > 0)
        {
            DataManager.money += amount;
            MoneyChanged?.Invoke(DataManager.money);
        }
    }

    public bool SpendMoney(int amount)
    {
        if (amount > 0 && DataManager.money >= amount)
        {
            DataManager.money -= amount;
            MoneyChanged?.Invoke(DataManager.money);
            return true;
        }
        return false;
    }

    public bool CanAfford(int amount)
    {
        return DataManager.money >= amount;
    }
}
