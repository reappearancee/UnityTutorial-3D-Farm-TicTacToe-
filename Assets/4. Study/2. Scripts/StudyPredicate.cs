using System;
using UnityEngine;

public class StudyPredicate : MonoBehaviour
{
// 접근제한자 Predicate<매개변수> 변수명 
    public Predicate<int> myPredicate;
    
    // 매개변수 1개만 사용 가능

    public int level = 10;

    void Start()
    {
        LevelCheck(level);
    }

    private void LevelCheck(int level)
    {
        if (level <= 10)
        {
            Debug.Log("초보자 사냥터 입장 가능");
        }
        else
        {
            Debug.Log("초보자 사냥터 입장 불가능");
        }
    }
}