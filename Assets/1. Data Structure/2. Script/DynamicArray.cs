using System.Collections.Generic;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    //동적배열
    private object[] array = new object[0];

    public void Add(object o)
    {
        var temp = new object[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
            temp[i] = array[i];
        
        array = temp;
        array[array.Length - 1] = o;
    }
}

