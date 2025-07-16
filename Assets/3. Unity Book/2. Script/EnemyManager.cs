using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private float currentTime;

    private float minTime = 1;
    private float maxTime = 5;
    
    public float createTime = 1f;

    public GameObject enemyFactory;

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        
        if (currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
            
            currentTime = 0f;
        }
    }        
}
