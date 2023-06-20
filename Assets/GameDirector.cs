using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϹǷ� ���� �ʰ� �߰��Ѵ�

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;      //�������� ��Ÿ���� ��ü
    public int score;        // ����
    public Text NowScore;   //�ְ������� ��Ÿ���� �ؽ�Ʈ ��ü
    public Text BestScore;
    public Text scoreTxt;    //���� ��ܿ� Score ���� ��Ÿ���� �ؽ�Ʈ ��ü
    public GameObject panel; //�г� ��ü
    public bool stopTrigger = true;
 
   
    
    public void GameStart()
    {
        Time.timeScale = 1f;                    //���� �簳
        score = 0;                              //���� �ʱ�ȭ
        scoreTxt.text = " Score : " + score;    //���� ��ܿ� " Score : �� "�� ��Ÿ��
        stopTrigger = true;
        panel.SetActive(false);                 //â�� �ȳ�Ÿ������ ��
       
    }
    public void GameOver()
    {
        stopTrigger = false;
       
        NowScore.text = ""+ score;                                //ȹ�� ����
        if (score >= PlayerPrefs.GetInt("BestScore", 0))          //�ְ� ����
            PlayerPrefs.SetInt("BestScore", score);

        BestScore.text = PlayerPrefs.GetInt("BestScore", 0).ToString();


        this.hpGauge.GetComponent<Image>().fillAmount =1f;
        panel.SetActive(true);                 //â�� ��Ÿ��
        Time.timeScale = 0f;                   //���� �Ͻ�����
    }


    void Start()
    {
        
        GameStart();
        this.hpGauge = GameObject.Find("hpGauge");
    }
    void Update()
    {

    }

    public void DecreaseHp()  //������ ���̱� ���� �Լ�
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
    public void FireDecreaseHp()  //�ҵ��̸� �¾��� �� ������ ���̱� ���� �Լ�
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
    public void IncreaseHp()        //���� ȸ��
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.2f;
    }
    public void Score()       //������ ǥ���ϱ� ���� �Լ�
    {
        if(stopTrigger)
        score++;
        scoreTxt.text = "Score : " + score;
    }
   
}