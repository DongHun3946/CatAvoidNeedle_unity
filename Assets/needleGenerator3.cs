using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needleGenerator3 : MonoBehaviour
{
    public GameObject needlePrefab3;  // 바늘 프리팹
    float span = 0.1f;               // 바늘 생성 간격(초 단위)
    float delta = 0;                 // 경과 시간 (deltaTime 값을 누적하여 경과 시간 추적)

    public GameDirector gameDirector; // GameDirector 스크립트를 참조하기 위한 변수

    void Start()
    {
        gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    void Update()
    {
        // score가 100 이상인 경우에만 바늘 생성
        if (gameDirector.score >= 200)
        {
            this.delta += Time.deltaTime; // 경과 시간 측정

            if (this.delta > this.span)
            {
                this.delta = 0;                                  // 바늘 생성 후 경과 시간 초기화
                GameObject go = Instantiate(needlePrefab3);       // 바늘 프리팹을 복제하여 게임 오브젝트 go로 생성
                int px = Random.Range(-12, 13);                    // -6 부터 6까지 랜덤한 x 좌표 생성
                go.transform.position = new Vector3(px, 7, 0);   // 생성된 바늘의 위치를 설정. x 좌표는 랜덤값인 px, y는 7, z는 0으로 설정
            }
        }
    }
}
