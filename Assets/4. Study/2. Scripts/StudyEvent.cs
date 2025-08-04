using UnityEngine;
using UnityEngine.Events;

public class StudyEvent : MonoBehaviour
{
    public UnityEvent onUnityEvent;

    void OnEnable()
    {
        onUnityEvent.AddListener(MethodA);
    }

    void OnDisable()
    {
        onUnityEvent.RemoveListener(MethodA);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onUnityEvent?.Invoke();
        }
    }

    private void MethodA()
    {
        Debug.Log("MethodA");
    }
}