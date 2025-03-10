using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public float jumpForce = 5.0f; //점프 힘


    void Update()
    {
        //space 키를 누르면 점프
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            rb.freezeRotation = true;
        }
    }
}
