using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 dir;
    public float speed = 5;

    public GameObject explosionFactory;
    
    void Start()
    {
        int ranValue = UnityEngine.Random.Range(0, 10);

        if (ranValue < 3) // 30% 확률로 Player쪽으로 
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position; // 플레이어를 바라보는 방향 값
            dir.Normalize();
        }
        else // 70% 확률로 아래로 내려감
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {
        transform.position += dir * speed * Time.deltaTime; // 속도
    }
    
    private void OnCollisionEnter(Collision other)
    {
        GameObject smObject = GameObject.Find("ScoreManager");//ScoreManager 스크립트
        ScoreManager sm = smObject.GetComponent<ScoreManager>(); 
        
        var score = sm.GetScore() + 1; 
        sm.SetScore(score);

        //파티클 생성
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        
        //파괴
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}