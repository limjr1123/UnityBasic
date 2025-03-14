using UnityEngine;
using UnityEngine.InputSystem;

public class Launcher : MonoBehaviour
{
    ////미사일 프리펩 가져오기
    //public GameObject bullet;
    void Start()
    {
        //InvokeRepeating("Shoot", 0.1f, 0.1f);
    }

    void Shoot()
    {
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    //미사일 프리팹, 런쳐포지션, 방향값 안줌
        //    Instantiate(bullet, transform.position, Quaternion.identity);
        //}
        //사운드 사용해보기 사운드 매니져에서 
        //SoundManager.instance.PlayBulletSound();
    }

    void Update()
    {
        
    }
}
