using System;
using UnityEditor.SceneManagement;
using UnityEngine;

public class StudyEventHandler : MonoBehaviour
{
    public class CharacterData : EventArgs
    {
        public string name;
        public int level;
        public float hp;
        public float mp;
        public float dmg;

        public CharacterData(string name, int level, float hp, float mp, float dmg)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
            this.dmg = dmg;
        }
    }

    private event EventHandler handler;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CharacterData data = new CharacterData("A", 1, 2, 3, 4);
            handler?.Invoke(this, data);
        }
    }

    private void CreateCharacter(object o, EventArgs e)
    {
        
        var data = (CharacterData)e;
        Debug.Log("CreateCharacter");
    }

}


