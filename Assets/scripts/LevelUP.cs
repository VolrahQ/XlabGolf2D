using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUP : MonoBehaviour
{
    public int levelcost = 1000;
    public void TblLevelUP()
    {
        if (MoneyManager.Instance.TrySpendMoney(levelcost))
        {
            DataManager.tableLevel++;
        }
    }
    public void TskLevelUP()
    {
        if (MoneyManager.Instance.TrySpendMoney(levelcost))
        {
            DataManager.taskLevel++;
        }
    }
}
