using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PersonData
{
    public int age;
    public string name;
    public float height;
    public float weight;

    public PersonData(int _age, string _name, float _height, float _weight)
    {
        age = _age;
        name = _name;
        height = _height;
        weight = _weight;
    }

    public class StudyDictionary : MonoBehaviour
    {
        public Dictionary<string, PersonData> persons = new Dictionary<string, PersonData>();

        void Start()
        {
            persons.Add("철수", new PersonData(13, "철수", 150f, 50f));
        }
    }
}

