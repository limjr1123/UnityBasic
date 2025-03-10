using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public float jumpForce = 5.0f; //���� ��


    void Update()
    {
        //space Ű�� ������ ����
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rb.freezeRotation = true;
        }
    }
}
