using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Sttart : ������ ���۵� �� ȣ�� �˴ϴ�.");
    }

    void Update()
    {
        Debug.Log("Update : �����Ӹ��� ȣ�� �˴ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate : ���� ���꿡 ��µ˴ϴ�.");
    }

    //ctrl + shift + m => �Լ� ȣ�⸮��Ʈ
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
