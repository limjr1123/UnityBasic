using UnityEngine;

public class Monster2 : MonoBehaviour
{
    public int HP = 300;
    public float Speed = 3;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;
    public GameObject Item;


    void Start()
    {
        //매서드 실행
        Invoke("CreateBullet", Delay);

    }
    void CreateBullet()
    {
        // Instantiate(object, 위치, 회전) : 게임 오브젝트를 동적으로 생성
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);
        
        Invoke("CreateBullet", Delay);
    }
    void Update()
    {
        // 객체의 변환 정의(위치 ,회전 ,스케일)
        // 아래로 위치 이동
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void ItemDrop()
    {
        Instantiate(Item, transform.position, Quaternion.identity);
    }

    //미사일에 따른 데미지 입는 함수
    public void Damage(int attack)
    {
        HP -= attack;
        if (HP <= 0)
        {
            ItemDrop();
            Destroy(gameObject);
        }
    }
}
