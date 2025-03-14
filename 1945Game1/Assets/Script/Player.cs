using UnityEngine;

public class Player : MonoBehaviour
{
    //1. moveing 
    public float moveSpeed = 5f;

    //2. 화면의 경계 설정
    private Vector2 minBounds;
    private Vector2 maxBounds;

    //3. 애니메이터를 가져올 변수
    Animator ani;

    //4. 총알
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;

    public int power = 1;

    public Transform pos = null;


    void Start()
    {
        //2. 화면의 경계 설정
        Camera cam = Camera.main;
        Vector3 bottomLeft = cam.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = cam.ViewportToWorldPoint(new Vector3(1, 1, 0));

        minBounds = new Vector2(bottomLeft.x, bottomLeft.y);
        maxBounds = new Vector2(topRight.x, topRight.y);

        //3. 애니메이터
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        //1. moveing 방향키 움직임
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        //3. 애니메이터 -1   0   1
        if (Input.GetAxis("Horizontal") <= -0.5f)
            ani.SetBool("left", true);
        else
            ani.SetBool("left", false);

        if (Input.GetAxis("Horizontal") >= 0.5f)
            ani.SetBool("right", true);
        else
            ani.SetBool("right", false);

        if (Input.GetAxis("Vertical") >= 0.5f)
            ani.SetBool("up", true);
        else
            ani.SetBool("up", false);

        //transform.Translate(moveX, moveY, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //프리펩 위치 방향 넣고 생성
            //POWER 획득 대비 미사일 변경
            if (power == 1)
                Instantiate(bullet, pos.position, Quaternion.identity);
            else if (power == 2)
                Instantiate(bullet2, pos.position, Quaternion.identity);
            else
                Instantiate(bullet3, pos.position, Quaternion.identity);

        }




        //2. 화면의 경계 설정
        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0);

        newPosition.x = Mathf.Clamp(newPosition.x, minBounds.x, maxBounds.x);
        newPosition.y = Mathf.Clamp(newPosition.y, minBounds.y, maxBounds.y);

        transform.position = newPosition;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            power++;
        }
    }

}
