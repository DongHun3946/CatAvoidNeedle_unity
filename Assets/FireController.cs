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
        // �����Ӹ��� ������� ���Ͻ�Ų��
        transform.Translate(0, -0.1f, 0);

        // ȭ�� ������ ������ ������Ʈ�� �����Ѵ�
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().Score();
        }

        // �浹 ����
        Vector2 p1 = transform.position;              // �ҵ����� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;  // �ҵ��� �ݰ�
        float r2 = 1.0f;  // �÷��̾� �ݰ�

        if (d < r1 + r2)
        {

            GameObject director = GameObject.Find("GameDirector"); // ���� ��ũ��Ʈ�� �÷��̾�� ȭ���� �浹�ߴٰ� �����Ѵ� 
            director.GetComponent<GameDirector>().FireDecreaseHp();    // GameDirector �� Decrease �Լ� ȣ��



            Destroy(gameObject);                                   // �浹�ߴٸ� �ҵ����� �����
        }
    }
}