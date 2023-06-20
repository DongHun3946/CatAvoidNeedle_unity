using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needleGenerator : MonoBehaviour
{
    public GameObject needlePrefab;           // �ٴ� ������
    float span = 0.5f;                       // �ٴ� ���� ����(�� ����)
    float delta = 0;                         // ��� �ð� ( deltaTime ���� �����Ͽ� ��� �ð� ���� )

    void Update()
    {
        this.delta += Time.deltaTime;        //��� �ð� ����
        if (this.delta > this.span)
        {
            this.delta = 0;                                  //�ٴ� ������ ����ð� �ʱ�ȭ
            GameObject go = Instantiate(needlePrefab);       //�ٴ� �������� �����Ͽ� ���� ������Ʈ go�� ����
            int px = Random.Range(-12, 13);                    //-6 ���� 6���� ������ x ��ǥ ����
            go.transform.position = new Vector3(px, 7, 0);   //������ �ٴ��� ��ġ�� ���� x ��ǥ�� �������� px, y�� 7, z�� 0���� ����
        }
    }
}
