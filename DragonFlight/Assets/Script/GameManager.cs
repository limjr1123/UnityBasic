using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //�̱���
    //��𿡼��� ������ �� �ֵ��� static ���� �ڱ��ڽ��� �����ؼ� �̰����̶�� ������������ ����غ���.
    public static GameManager instance;
    public Text scoreText;  //������ ǥ���ϴ� text��ü�� �����Ϳ��� �޾ƿ�.
    public Text StartText;  //Start Text

    int score = 0; //������ �����մϴ�.
    private void Awake()
    {
        if(instance == null)    //�������� �ڽ��� üũ 
        {
            instance = this;    //�ڱ��ڽ��� �����Ѵ�.
        }
    }

    void Start()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        int i = 3;
        while (i > 0)
        {
            StartText.text = i.ToString();
            yield return new WaitForSeconds(1);
            i--;

            if (i == 0)
            {
                StartText.gameObject.SetActive(false);
            }
        }
    }

    public void AddScore(int num)
    {
        score += num;   //������ ����
        scoreText.text = "Score : " + score;    //�ؽ�Ʈ�� �ݿ��մϴ�.
    }
}
