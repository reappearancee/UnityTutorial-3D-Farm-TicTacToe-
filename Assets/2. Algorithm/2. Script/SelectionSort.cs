using UnityEditor.Rendering;
using UnityEngine;

public class SelectionSort : MonoBehaviour
{
    private int[] array = { 5, 2, 1, 8, 3, 7, 6, 4 };
    void Start()
    {
        Debug.Log("정렬 전 : " + string.Join(",", array));

        Selection(array);
        Debug.Log("정렬 전 : " + string.Join(",", array));
    }

    private void Selection(int[] arr)
    {
        int n  = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                
            }
        }
    }
}
