using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionGenerator : MonoBehaviour
{
    public GameObject potionPrefab;           // 포션 프리팹
    float span = 10f;                       // 포션 생성 간격(초 단위)
    float delta = 0;                         // 경과 시간 ( deltaTime 값을 누적하여 경과 시간 추적 )
   
    void Start()
    {
        
    }

    
    void Update()
    {
        this.delta += Time.deltaTime;        //경과 시간 측정
        if (this.delta > this.span)
        {
            this.delta = 0;                                  //포션 생성후 경과시간 초기화
            GameObject pos = Instantiate(potionPrefab);        //포션 프리팹을 복제하여 게임 오브젝트 go로 생성
            int px = Random.Range(-6, 7);                    //-6 부터 6까지 랜덤한 x 좌표 생성
            pos.transform.position = new Vector3(px, -4, 0);   //생성된 화살표의 위치를 설정 x 좌표는 랜덤값인 px, y는 7, z는 0으로 설정
        }
    }
}
