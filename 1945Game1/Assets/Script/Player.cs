using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //1. moveing 
    public float moveSpeed = 5f;

    //2. 화면의 경계 설정
    private Vector2 minBounds;
    private Vector2 maxBounds;

    //3. 애니메이터를 가져올 변수
    Animator ani;

    ////4. 총알
    //public GameObject bullet;
    //public GameObject bullet2;
    //public GameObject bullet3;
    public GameObject[] bullet;

    //5. 레이져
    public GameObject Lazer;
    public float gValue = 0;

    public int power = 0;


    public Image Gage;
    
    //보안 강화
    [SerializeField]
    private GameObject powerUp; //private 인스펙터에서 사용하는 방법

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
        //GetComponent : 다른 객체에 액세스하기 위함
        ani = GetComponent<Animator>();
    }

    void Update()
    {
        //1. moveing 방향키 움직임
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");

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
            Instantiate(bullet[power], pos.position, Quaternion.identity);
        }

        else if (Input.GetKey(KeyCode.Space))
        {
            gValue += Time.deltaTime;
            Gage.fillAmount = gValue;
            
            if (gValue >= 1) 
            {
                GameObject go = Instantiate(Lazer, pos.position, Quaternion.identity);
                Destroy(go,3);
                gValue = 0;
            }
        }
        else
        {
            gValue -= Time.deltaTime;
            if(gValue <= 0)
            {
                gValue = 0;
            }
            Gage.fillAmount = gValue;
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
            if (power >= 3)
                power = 3;
            else
            {
                //파워업
                GameObject go = Instantiate(powerUp, transform.position , Quaternion.identity);
                Destroy(go, 1);
            }

            //먹은 아이템 처리
            Destroy(collision.gameObject);
        }
    }

}
