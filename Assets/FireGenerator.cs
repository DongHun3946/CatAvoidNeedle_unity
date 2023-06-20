using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour
{
    public GameObject FirePrefab;           // ȭ��ǥ ������
    float span = 6.0f;                       // ȭ��ǥ ���� ����(�� ����)
    float delta = 0;                         // ��� �ð� ( deltaTime ���� �����Ͽ� ��� �ð� ���� )

    void Update()
    {
        this.delta += Time.deltaTime;        //��� �ð� ����
        if (this.delta > this.span)
        {
            this.delta = 0;                                  //ȭ��ǥ ������ ����ð� �ʱ�ȭ
            GameObject fire = Instantiate(FirePrefab);        //ȭ��ǥ �������� �����Ͽ� ���� ������Ʈ go�� ����
            int px = Random.Range(-10, 11);                    //-6 ���� 6���� ������ x ��ǥ ����
            fire.transform.position = new Vector3(px, 7, 0);   //������ ȭ��ǥ�� ��ġ�� ���� x ��ǥ�� �������� px, y�� 7, z�� 0���� ����
        }
    }
}