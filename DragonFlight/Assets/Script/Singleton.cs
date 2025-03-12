using UnityEngine;

public class Singleton : MonoBehaviour
{
    //����Ƽ���� �̱����� ����ϸ� �ϳ��� �ν��Ͻ��� �����ϸ鼭 ��𼭵� ���� �����ϰ� ����� �ִ�.
    public static Singleton Instance { get; private set; }

    // Awake : Start�� ���� �������� ������ ������ ó�� �ѹ��� ������
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  //���� �ٲ� �����ǰ� �ϴ��Լ� 
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void PrintMessage()
    {
        Debug.Log("�̱��� �޽��� ���");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
