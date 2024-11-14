using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Train : MonoBehaviour
{
    private Timer timerComponent;
    public Transform trainDestination;

    private void Start()
    {
        timerComponent = GetComponent<Timer>();
        timerComponent.OnTimerChanged += HandleTimerChange;
    }

    private void UpdateTrainPosition()
{
    float speed = 1f; // Adjust the speed as needed
    float distance = Vector2.Distance(transform.position, trainDestination.position);
    float step = speed * Time.deltaTime;

    if (distance > step)
    {
        transform.position = Vector2.MoveTowards(transform.position, trainDestination.position, step);
    }
    else
    {
        transform.position = trainDestination.position;
    }
}

    private void OnDestroy()
    {
        timerComponent.OnTimerChanged -= HandleTimerChange;
    }

    private void HandleTimerChange()
    {
        UpdateTrainPosition();
    }
}