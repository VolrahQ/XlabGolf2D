using System;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float updateInterval = 0.5f;

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
            MoneyManager.Instance.TrySpendMoney(100);
        }
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }
}