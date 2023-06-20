using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f; // �̵� �ӵ� ���� ����
    private bool moveLeft = false;
    private bool moveRight = false;

    void Update()
    {
        float moveDistance = moveSpeed * Time.deltaTime * 2;

        // ���� ȭ��ǥ Ű�� ���� ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }

        // ���� ȭ��ǥ Ű�� �� ��
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            moveLeft = false;
        }

        // ������ ȭ��ǥ Ű�� ���� ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRight = true;
        }

        // ������ ȭ��ǥ Ű�� �� ��
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveRight = false;
        }

        // �������� �̵�
        if (moveLeft)
        {
            transform.Translate(-moveDistance, 0, 0);
        }

        // ���������� �̵�
        if (moveRight)
        {
            transform.Translate(moveDistance, 0, 0);
        }
    }
}

