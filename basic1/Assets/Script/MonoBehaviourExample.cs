using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Sttart : 게임이 시작될 때 호출 됩니다.");
    }

    void Update()
    {
        Debug.Log("Update : 프레임마다 호출 됩니다.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate : 물리 연산에 출력됩니다.");
    }

    //ctrl + shift + m => 함수 호출리스트
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
