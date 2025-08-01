using UnityEngine;

public class StudyStatic : MonoBehaviour
{

    public class StaticClass
    {
        public static StaticClass instance = new StaticClass();
        public static int num = 10;
        
        
    }
}
