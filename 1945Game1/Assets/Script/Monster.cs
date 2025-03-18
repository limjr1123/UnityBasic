using UnityEngine;

public class Monster : MonoBehaviour
{
    public int HP = 100;
    public float Speed = 3;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;
    public GameObject Item;


    void Start()
    {
        Invoke("CreateBullet", Delay);

    }
    void CreateBullet()
    {
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
        //풀
        //PoolManager.Instance.Return(gameObject);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Bullet"))
    //    {
    //        int random = Random.Range(1,10);
    //        if(random <= 3)
    //            ItemDrop();
    //    }
    //}

    void ItemDrop()
    {
        Instantiate(Item, transform.position, Quaternion.identity);
    }

    //미사일에 따른 데미지 입는 함수
    public void Damage(int attack)
    {
        HP -= attack;
        if(HP <= 0)
        {
            ItemDrop();
            Destroy(gameObject);
            //풀
            //PoolManager.Instance.Return(gameObject);
        }
    }
}
