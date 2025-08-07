using UnityEngine;

public class SaveService : MonoBehaviour,ISaveService
{
    public void SaveData()
    {
        Debug.Log("Save data");
    }

    public void LoadData()
    {
        Debug.Log("Load data");
    }
}
