using UnityEngine;

public class FunctionExample : MonoBehaviour
{
    //�Լ� ���� 
    void SayHello()
    {
        Debug.Log("Hello, Unity");
    }
    int AddNumber(int a, int b)
    {
        return a + b;
    }

    void Start()
    {
        SayHello();
        int total = AddNumber(3, 5);
        Debug.Log("total :" + total);
    }



    void Update()
    {

    }
}
