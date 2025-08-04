using System;
using UnityEngine;

public class StudyAction : MonoBehaviour
{
    public delegate void MyDelegate();
    public MyDelegate myDelegate;
    
    public Action action;
    
    
    public delegate void MyDelegate2(string s);
    public MyDelegate myDelegate2;
    
    public Action<string> action2;

    public Action<string, int, float, bool> action3;
}