using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionContoller : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
        StartCoroutine(WaitAndDestroy(5f));           //5�� �Ŀ� ������ �ı��ϴ� �ڷ�ƾ ����
    }

    void Update()
    {
        Vector2 p1 = transform.position;              // ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  // ���� �ݰ�
        float r2 = 0.8f;  // �÷��̾� �ݰ�

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

