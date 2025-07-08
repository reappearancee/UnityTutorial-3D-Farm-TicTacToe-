using UnityEngine;

public class JaggedArray : MonoBehaviour
{
    public int[] array1 = new int[3];
    public int[][] jaggedArray1 = new int[3][]; //배열이 3개

    void Start()
    {
        jaggedArray1[0] = new int[] { 1, 2, 3 };
        jaggedArray1[1] = new int[] { 4, 5 };
        jaggedArray1[2] = new int[] { 6, 7, 8, 9 };
        
    }
}


