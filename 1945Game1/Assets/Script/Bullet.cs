using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 4.0f;

    public int Attack = 10;
    //이펙트
    public GameObject effect;

    //공격력


    void Update()
    {
        //Y축 이동(방향, 속도, 시간)
        //transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        //미사일이 화면밖으로 나갔으면 지우기
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            //이펙트 생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            //몬스터 삭제(다른 클래스 함수 호출)
            //collision.gameObject.GetComponent<Monster>().Damage(Attack);
            //collision.gameObject.GetComponent<Monster2>().Damage(1);
            PoolManager.Instance.Return(gameObject);

            //미사일 삭제
            Destroy(gameObject);
        }

        if (collision.CompareTag("Boss"))
        {
            //이펙트 생성
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);


            //미사일 삭제
            Destroy(gameObject);
            //Destroy(collision.gameObject);
        }
    }
}
