using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //싱글톤
    //어디에서나 접근할 수 있도록 static 으로 자기자신을 저장해서 싱골톤이라는 디자인패턴을 사용해본다.
    public static GameManager instance;
    public Text scoreText;  //점수를 표시하는 text객체를 에디터에서 받아옴.
    public Text StartText;  //Start Text

    int score = 0; //점수를 관리합니다.
    private void Awake()
    {
        if(instance == null)    //정적으로 자신을 체크 
        {
            instance = this;    //자기자신을 저장한다.
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
        score += num;   //점수를 더함
        scoreText.text = "Score : " + score;    //텍스트에 반영합니다.
    }
}
