using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //싱글톤
    public static SoundManager instance; //자기자신을 변수로 담기
    public AudioClip SoundBullet;
    public AudioClip soundDie;

    AudioSource myAudio; // AudioSource 컴포넌트를 변수로 담는다.

    private void Awake()
    {
        {
            if(SoundManager.instance == null)   //인스턴스가 있는지 검사
            {
                SoundManager.instance = this;
            }
        }
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void PlayBulletSound()
    {
        myAudio.PlayOneShot(SoundBullet);
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
}
