using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //몬스터 가지고오기
    public GameObject Enemy;
    public GameObject Enemy_normal;
    public float randomX;

    //적을 생성하는 함수
    void SpawnEnemy()
    {
        randomX = Random.Range(-2f, 2f); //적이 나타날 x 좌표를 랜덤으로 생성
        //Instantiate(Enemy_normal, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        if (Time.time <= 10)
            //적을 생성한다. randomX 랜덤한 x값
            Instantiate(Enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        else
            Instantiate(Enemy_normal, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
    }
    void Start()
    {
        //SpawnEnemy 1 0.5f 
        InvokeRepeating("SpawnEnemy", 1, 1.0f);
    }

    void Update()
    {
        
    }
}
