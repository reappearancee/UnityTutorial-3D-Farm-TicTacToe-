using UnityEngine;

public class MultidDeimensionalArray : MonoBehaviour
{
    //다차원 배열
    
    public int[,] array1 = new int[3,3]; //행과 3열이 3개인 2차원 배열
    public int[,,] array2 = new int[3, 3, 3]; //3차원 배열

    void Start()
    {
        int[,] matrix = new int[3,3];
        matrix[1,2] = 25;
        
        Debug.Log(matrix[1,2]); // 25
    }
}

