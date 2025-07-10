using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolQueue : MonoBehaviour
{
    public Queue<GameObject> objQueue = new Queue<GameObject>(); //오브젝트가 들어갈 큐
    
    public GameObject objPrefab; //생성할 오브젝트
    public Transform parent; // 계층 구조상 들어갈 부모 오브젝트

    void Start()
    {
        CreateObject();
    }
    private void CreateObject() //생성하는 기능
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject obj = Instantiate(objPrefab, parent); //오브젝트 생성, parent의 자식으로 변경 
            
            objQueue.Enqueue(obj);
        }
    }

    public void EnqueueObject(GameObject newObj)
    {
        newObj.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        newObj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        
        objQueue.Enqueue(newObj);
        newObj.SetActive(false);
    }

    public GameObject DequeueObject()
    {
        if (objQueue.Count < 10)
            CreateObject();
        
        GameObject obj = objQueue.Dequeue();
        obj.SetActive(true);
        
        return obj;
    }
}
