using UnityEngine;

public class Monster2 : MonoBehaviour
{
    public float Speed = 3;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;


    void Start()
    {
        //매서드 실행
        Invoke("CreateBullet", Delay);

    }
    void CreateBullet()
    {
        // Instantiate(object, 위치, 회전) 객체를 복제 
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);
        
        Invoke("CreateBullet", Delay);
    }
    void Update()
    {
        //아래 방향으로 움직여라
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    
}
