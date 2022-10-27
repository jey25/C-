using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2D : MonoBehaviour
{

    //2D 오브젝트끼리 충동 시 떨림 현상이 발생하지 않는 코드
    private float moveSpeed = 5.0f;   //이동속도
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //좌우이동
        float y = Input.GetAxisRaw("Vertical"); //위아래 이동

        //rigidbody2D 컴포넌트에 있는 속력(velocity) 변수 설정
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;

    }
}
