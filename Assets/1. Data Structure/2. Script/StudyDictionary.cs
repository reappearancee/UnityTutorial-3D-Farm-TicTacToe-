using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, int> persons = new Dictionary<string, int>();

    void Start()
    {
        persons.Add("철수",13);
        persons.Add("영희",14);
        persons.Add("동수",15);
        
        int age = persons["철수"];
        Debug.Log($"철수의 나이는{age}입니다.");
        
        foreach (var person in persons)
        {
            if(person.Value == 15)
                Debug.Log($"나이가 15세 인 사람은 {persons[person.Key]} 입니다.");
        }
    }
}
