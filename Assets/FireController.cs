using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하시킨다
        transform.Translate(0, -0.1f, 0);

        // 화면 밖으로 나오면 오브젝트를 삭제한다
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().Score();
        }

        // 충돌 판정
        Vector2 p1 = transform.position;              // 불덩이의 중심 좌표
        Vector2 p2 = this.player.transform.position;  // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;  // 불덩이 반경
        float r2 = 1.0f;  // 플레이어 반경

        if (d < r1 + r2)
        {

            GameObject director = GameObject.Find("GameDirector"); // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달한다 
            director.GetComponent<GameDirector>().FireDecreaseHp();    // GameDirector 의 Decrease 함수 호출



            Destroy(gameObject);                                   // 충돌했다면 불덩이을 지운다
        }
    }
}
