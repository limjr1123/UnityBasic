using UnityEngine;

public class Item : MonoBehaviour
{
    //아이템 속도
    public float ItemVelocity = 20f;
    Rigidbody2D rig = null;


    void Start()
    {
        //Component를 사용한 오브젝트 제어
        //GetComponent를 사용하여 Rigibody컴포넌트를 가져오고 AddForce 로 벡터 제어
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(ItemVelocity, ItemVelocity, 0));
    }

    void Update()
    {
        
    }
    // Collider2D : 물리적 충돌을 위한 2D 게임 오브젝트의 모양을 정의

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        Debug.Log("아이템 충돌로그");
    //        Destroy(gameObject);
    //    }
    //}
    
}
