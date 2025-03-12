using UnityEngine;

public class Singleton : MonoBehaviour
{
    //유니티에서 싱글톤을 사용하면 하나의 인스턴스만 유지하면서 어디서든 접근 가능하게 만들수 있다.
    public static Singleton Instance { get; private set; }

    // Awake : Start의 시작 시점보다 실행이 빠르며 처음 한번만 실행함
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  //씬이 바뀌어도 유지되게 하는함수 
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void PrintMessage()
    {
        Debug.Log("싱글톤 메시지 출력");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
