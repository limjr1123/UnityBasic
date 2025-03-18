using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Homing : MonoBehaviour
{
    public GameObject target;

    public float Speed = 3f;
    Vector2 dir;
    Vector2 dirNo;

    void Start()
    {
        //플레이어 Tag로 찾기
        target = GameObject.FindGameObjectWithTag("Player");

        //// -> update에 놓으면 계속 추척
        // A - B 플레이어A 를 바라보는 벡터
        // 플레이어 position - 미사일 position
        dir = target.transform.position - transform.position;

        //방향벡터만 구하기 : 단위 벡터 정규화 노말1의 크기로 만든다.
        dirNo = dir.normalized;
    }

    void Update()
    {
        transform.Translate(dirNo * Speed * Time.deltaTime);
        //추적 한줄처리 시 아래와 같이 사용
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position , Speed * Time.deltaTime);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
