using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public GameObject exposion;
    void Start()
    {
        //Singleton.Instance.PrintMessage();
    }

    void Update()
    {
        //Y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);    
    }

    private void OnBecameInvisible()
    {
        //미사일이 화면밖으로 나갔으면 지우기
        Destroy(gameObject);
    }

    //2D충돌 트리거이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딫혔다
        //if(collision.gameObject.tag == "Enemy")
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //폭발 이펙트 생성
            Instantiate(exposion, transform.position, Quaternion.identity);
            //죽음 사운드
            SoundManager.instance.SoundDie(); //적 죽음 사운드

            //적지우기
            Destroy(collision.gameObject);
            //총알 지우기 자기자신
            Destroy(gameObject);

            GameManager.instance.AddScore(10);
        }
    }
}
