using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static int money;
    public static int tableLevel;
    public static int taskLevel;
    public static string savePath;

    private void Start()
    {
        savePath = Application.persistentDataPath + "/gameData.json";
        Load();
    }
    public static void Save()
    {
        GameData data = new GameData();
        data.money = money;
        data.tableLevel = tableLevel; 
        data.taskLevel = taskLevel;
        string jsonData = JsonUtility.ToJson(data);
        System.IO.File.WriteAllText(savePath, jsonData);
    }
    public static void Load() 
    {   
    if (System.IO.File.Exists(savePath))
        {
            string jsonData = System.IO.File.ReadAllText(savePath);
            GameData data = JsonUtility.FromJson<GameData>(jsonData);
            money = data.money;
            tableLevel = data.tableLevel;
            taskLevel = data.taskLevel;
        }
    else {
            money = 10;
            tableLevel = 1; 
            taskLevel = 1;
         }
    }
}
public class GameData
{
    public int money;
    public int tableLevel;
    public int taskLevel;
}
