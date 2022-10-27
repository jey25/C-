using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2D : MonoBehaviour
{

    private float moveSpeed = 5.0f;   //이동속도
    private Vector3 moveDirection = Vector3.zero; //이동방향

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //좌우이동
        float y = Input.GetAxisRaw("Vertical"); //위아래 이동

        moveDirection = new Vector3(x, y, 0);  //이동방향 설정

        //새로운 위치 = 현재위치 + (방향 * 속도)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
