using UnityEngine;

public partial class StudyPartial : MonoBehaviour
{
    void Start()
    {
        MethodA();
        MethodB();
    }

    private void MethodA()
    {
        Debug.Log("Method A");
    }
    
}
public partial class StudyPartial : MonoBehaviour
{
    private void MethodB()
    {
        Debug.Log("Method B");
    }
}
