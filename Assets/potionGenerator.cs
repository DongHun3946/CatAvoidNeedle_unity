using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionGenerator : MonoBehaviour
{
    public GameObject potionPrefab;           // ���� ������
    float span = 10f;                       // ���� ���� ����(�� ����)
    float delta = 0;                         // ��� �ð� ( deltaTime ���� �����Ͽ� ��� �ð� ���� )
   
    void Start()
    {
        
    }

    
    void Update()
    {
        this.delta += Time.deltaTime;        //��� �ð� ����
        if (this.delta > this.span)
        {
            this.delta = 0;                                  //���� ������ ����ð� �ʱ�ȭ
            GameObject pos = Instantiate(potionPrefab);        //���� �������� �����Ͽ� ���� ������Ʈ go�� ����
            int px = Random.Range(-6, 7);                    //-6 ���� 6���� ������ x ��ǥ ����
            pos.transform.position = new Vector3(px, -4, 0);   //������ ȭ��ǥ�� ��ġ�� ���� x ��ǥ�� �������� px, y�� 7, z�� 0���� ����
        }
    }
}
