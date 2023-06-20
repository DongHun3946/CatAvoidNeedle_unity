using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needleGenerator2 : MonoBehaviour
{
    public GameObject needlePrefab2;  // �ٴ� ������
    float span = 0.3f;               // �ٴ� ���� ����(�� ����)
    float delta = 0;                 // ��� �ð� (deltaTime ���� �����Ͽ� ��� �ð� ����)

    public GameDirector gameDirector; // GameDirector ��ũ��Ʈ�� �����ϱ� ���� ����

    void Start()
    {
        gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    void Update()
    {
        // score�� 100 �̻��� ��쿡�� �ٴ� ����
        if (gameDirector.score >= 100)
        {
            this.delta += Time.deltaTime; // ��� �ð� ����

            if (this.delta > this.span)
            {
                this.delta = 0;                                  // �ٴ� ���� �� ��� �ð� �ʱ�ȭ
                GameObject go = Instantiate(needlePrefab2);       // �ٴ� �������� �����Ͽ� ���� ������Ʈ go�� ����
                int px = Random.Range(-12, 13);                    // -6 ���� 6���� ������ x ��ǥ ����
                go.transform.position = new Vector3(px, 7, 0);   // ������ �ٴ��� ��ġ�� ����. x ��ǥ�� �������� px, y�� 7, z�� 0���� ����
            }
        }
    }
}
