using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("�ڷ�ƾ ����");
        yield return new WaitForSeconds(2f); //2�� ���
        Debug.Log("2�� �� ����");
    }

    void Update()
    {
        
    }
}
