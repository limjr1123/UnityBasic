using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //�̱���
    public static SoundManager instance; //�ڱ��ڽ��� ������ ���
    public AudioClip SoundBullet;
    public AudioClip soundDie;

    AudioSource myAudio; // AudioSource ������Ʈ�� ������ ��´�.

    private void Awake()
    {
        {
            if(SoundManager.instance == null)   //�ν��Ͻ��� �ִ��� �˻�
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
