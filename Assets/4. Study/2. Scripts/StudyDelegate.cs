using UnityEngine;
using UnityEngine.UI;

public class StudyDelegate : MonoBehaviour
{
    public delegate void TimerStart();
    public TimerStart onTimerStart;
    
    public delegate void TimerEnd();
    public TimerEnd onTimerEnd;

    private float timer = 5f;

    void OnEnable()
    {
        onTimerStart += StartEvent;
        onTimerEnd += EndEvent;
    }
    void Start()
    {
        onTimerStart.Invoke();
    }

    void onDisable()
    {
        onTimerStart -= StartEvent;
        onTimerEnd -= EndEvent;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            
        }
    }

    private void StartEvent()
    {
        Debug.Log("StartEvent");
    }

    private void EndEvent()
    {
        Debug.Log("EndEvent");
    }
}