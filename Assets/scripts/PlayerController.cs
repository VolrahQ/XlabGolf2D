using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private ListSpawner spawner = new ListSpawner();
    public void BuyTaskButton()
    {
        spawner.ListSpawn();
    }
    public void SellTaskButton()
    {
        spawner.ListSell();
    }
    public void AddTaskButton()
    {
        spawner.ListTask();
    }
}
