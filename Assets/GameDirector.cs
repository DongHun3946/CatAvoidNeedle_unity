using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 않고 추가한다

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;      //게이지를 나타내는 객체
    public int score;        // 점수
    public Text NowScore;   //최고점수를 나타내는 텍스트 객체
    public Text BestScore;
    public Text scoreTxt;    //왼쪽 상단에 Score 값을 나타내는 텍스트 객체
    public GameObject panel; //패널 객체
    public bool stopTrigger = true;
 
   
    
    public void GameStart()
    {
        Time.timeScale = 1f;                    //게임 재개
        score = 0;                              //점수 초기화
        scoreTxt.text = " Score : " + score;    //왼쪽 상단에 " Score : 값 "을 나타냄
        stopTrigger = true;
        panel.SetActive(false);                 //창이 안나타나도록 함
       
    }
    public void GameOver()
    {
        stopTrigger = false;
       
        NowScore.text = ""+ score;                                //획득 점수
        if (score >= PlayerPrefs.GetInt("BestScore", 0))          //최고 점수
            PlayerPrefs.SetInt("BestScore", score);

        BestScore.text = PlayerPrefs.GetInt("BestScore", 0).ToString();


        this.hpGauge.GetComponent<Image>().fillAmount =1f;
        panel.SetActive(true);                 //창이 나타남
        Time.timeScale = 0f;                   //게임 일시중지
    }


    void Start()
    {
        
        GameStart();
        this.hpGauge = GameObject.Find("hpGauge");
    }
    void Update()
    {

    }

    public void DecreaseHp()  //생명을 줄이기 위한 함수
    {
        if (this.hpGauge.GetComponent<Image>().fillAmount > 0f)
        {
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        }
        else if (this.hpGauge.GetComponent<Image>().fillAmount <= 0f)
        {
            GameOver();
        }
    }
    public void FireDecreaseHp()  //불덩이를 맞았을 때 생명을 줄이기 위한 함수
    {
        if (this.hpGauge.GetComponent<Image>().fillAmount > 0f)
        {
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.5f;
        }
        else if (this.hpGauge.GetComponent<Image>().fillAmount <= 0f)
        {
            GameOver();
        }
    }
    public void IncreaseHp()        //생명 회복
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.2f;
    }
    public void Score()       //점수를 표현하기 위한 함수
    {
        if(stopTrigger)
        score++;
        scoreTxt.text = "Score : " + score;
    }
   
}