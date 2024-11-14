using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float updateInterval = 5f; // Интервал обновления в секундах

    private bool isTimerRunning = true;
    public event System.Action OnTimerChanged;

    private void Start()
    {
        StartCoroutine(UpdateTimer());
    }

    public IEnumerator UpdateTimer()
    {
        while (isTimerRunning)
        {
            yield return new WaitForSeconds(updateInterval);
            OnTimerChanged?.Invoke();
            Debug.Log("Timer updated");
        }
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }
}