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
        //������ �Ÿ� ���
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
    //ȭ�鿡�� ������ ������ ��ü �ı�
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
