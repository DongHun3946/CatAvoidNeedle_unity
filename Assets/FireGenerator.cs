using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour
{
    public GameObject FirePrefab;           // 화살표 프리팹
    float span = 6.0f;                       // 화살표 생성 간격(초 단위)
    float delta = 0;                         // 경과 시간 ( deltaTime 값을 누적하여 경과 시간 추적 )

    void Update()
    {
        this.delta += Time.deltaTime;        //경과 시간 측정
        if (this.delta > this.span)
        {
            this.delta = 0;                                  //화살표 생성후 경과시간 초기화
            GameObject fire = Instantiate(FirePrefab);        //화살표 프리팹을 복제하여 게임 오브젝트 go로 생성
            int px = Random.Range(-10, 11);                    //-6 부터 6까지 랜덤한 x 좌표 생성
            fire.transform.position = new Vector3(px, 7, 0);   //생성된 화살표의 위치를 설정 x 좌표는 랜덤값인 px, y는 7, z는 0으로 설정
        }
    }
}