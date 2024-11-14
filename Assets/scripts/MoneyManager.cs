using UnityEngine;
public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance { get; private set; }

    // Событие для обновления UI
    public delegate void OnMoneyChangedHandler(int currentMoney);
    public event OnMoneyChangedHandler MoneyChanged;

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

    public void AddFunds(int amount)
    {
        if (amount > 0)
        {
            DataManager.money += amount;
            MoneyChanged?.Invoke((int)DataManager.money);
        }
    }

    public bool TrySpendMoney(int amount)
    {
        if (amount > 0 && DataManager.money >= amount)
        {
            DataManager.money -= amount;
            MoneyChanged?.Invoke((int)DataManager.money);
            return true;
        }
        return false;
    }

    public bool HasEnoughMoney(int amount)
    {
        return DataManager.money >= amount;
    }
}
