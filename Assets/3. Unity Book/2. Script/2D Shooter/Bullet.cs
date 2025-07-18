using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;

    void Update() //총알
    {
        Vector3 dir = Vector3.up; // 위로 
        
        transform.position += dir * speed * Time.deltaTime; // 속도 값
    }
}