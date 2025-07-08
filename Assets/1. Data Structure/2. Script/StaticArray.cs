using UnityEngine;

public class StaticArray : MonoBehaviour
{
    //정적 배열
    
    int[] array; //정적 배열 선언만 한 상새
    
    private int[] array2 = { 1, 2, 3, 4, 5 }; // 선언 + 값 할당까지

    private int[] array3 = new int[5]; // 선언-> 공간만 선언
    
    private int[] array4 = new int[5] {1,2,3,4,5}; // 선언 -> 공간 + 값 할당까지

    //array2와 4는 아예 같다. 4는 오히려 비효율적이라 안쓰는 편.
}
