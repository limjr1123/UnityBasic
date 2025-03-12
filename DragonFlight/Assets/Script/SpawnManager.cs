using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //���� ���������
    public GameObject Enemy;
    public GameObject Enemy_normal;
    public float randomX;

    //���� �����ϴ� �Լ�
    void SpawnEnemy()
    {
        randomX = Random.Range(-2f, 2f); //���� ��Ÿ�� x ��ǥ�� �������� ����
        //Instantiate(Enemy_normal, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);
        if (Time.time <= 10)
            //���� �����Ѵ�. randomX ������ x��
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
