using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionContoller : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
        StartCoroutine(WaitAndDestroy(5f));           //5초 후에 포션을 파괴하는 코루틴 시작
    }

    void Update()
    {
        Vector2 p1 = transform.position;              // 화살의 중심 좌표
        Vector2 p2 = this.player.transform.position;  // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  // 포션 반경
        float r2 = 0.8f;  // 플레이어 반경

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            Destroy(gameObject);
        }
    }

    IEnumerator WaitAndDestroy(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}

