using UnityEngine;

public class EnemyNormal : MonoBehaviour
{
    public float moveSpeed = 2.3f;
    public SpawnManager smX;

    void Start()
    {
        
    }

    void Update()
    {
        //움직인 거리 계산
        float distanceY = moveSpeed * Time.deltaTime;
        float distanceX = moveSpeed * Time.deltaTime;
        //float distanceX = smX.randomX * Time.deltaTime;
        if(transform.position.x == 3.0f)
        {
            distanceX -= 2*moveSpeed * Time.deltaTime;
        }

        //if (distanceX <= 3)
        //    distanceX = moveSpeed * Time.deltaTime;
        //else if (Time.time <= 6)
        //    distanceX = distanceX - moveSpeed * Time.deltaTime;

        transform.Translate(distanceX, -distanceY, 0);
        Debug.Log(transform.position.x +","+ transform.position.y);
    }
    //화면에서 보이지 않으면 객체 파괴
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
