using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f; // 이동 속도 조절 변수
    private bool moveLeft = false;
    private bool moveRight = false;

    void Update()
    {
        float moveDistance = moveSpeed * Time.deltaTime * 2;

        // 왼쪽 화살표 키를 누를 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }

        // 왼쪽 화살표 키를 뗄 때
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            moveLeft = false;
        }

        // 오른쪽 화살표 키를 누를 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRight = true;
        }

        // 오른쪽 화살표 키를 뗄 때
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveRight = false;
        }

        // 왼쪽으로 이동
        if (moveLeft)
        {
            transform.Translate(-moveDistance, 0, 0);
        }

        // 오른쪽으로 이동
        if (moveRight)
        {
            transform.Translate(moveDistance, 0, 0);
        }
    }
}

