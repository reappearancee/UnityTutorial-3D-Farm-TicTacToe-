using System;
using UnityEngine;

public class StudyFunc : MonoBehaviour
{
    public enum Buff{A,B,C}

    public Buff buff;
    
    public Func<int, int, int> myFunc;

    void Start()
    {
        int result = myFunc(10, 20);
        
        Debug.Log(result);
    }

    private int AddMethod(int num1, int num2)
    {
        return num1 + num2;
    }

    private int RemoveMethod(int num1, int num2)
    {
        return num1 - num2;
    }
}
