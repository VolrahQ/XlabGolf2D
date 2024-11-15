using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using System;
using UnityEngine;

public class DelegateTable : MonoBehaviour
{
    public LevelManager _LevelManager;

    public void TableState()
    {
        if (_LevelManager.ClickToTable == 10)
        {
            _LevelManager.TableActive = false;
        }
    }
}
