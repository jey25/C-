using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("아무키 클릭");
        }

        // if (Input.GetKeyDown(KeyCode.Return))
        // {
        //     Debug.Log("아이템 구입");
        // }

        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     Debug.Log("왼쪽으로 이동 중");
        // }

        // if (Input.GetKeyUp(KeyCode.RightArrow))
        // {
        //     Debug.Log("오른쪽 이동을 멈춤");
        // }

        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("미사일 발사!");
        // }

        // if (Input.GetMouseButton(0))
        // {
        //     Debug.Log("미사일 모으는 중..");
        // }

        // if (Input.GetMouseButtonUp(0))
        // {
        //     Debug.Log("슈퍼 미사일 발사!");
        // }

        // if (Input.GetButtonDown("Jump"))
        // {
        //     Debug.Log("점프");
        // }

        // if (Input.GetButton("Jump"))
        // {
        //     Debug.Log("점프 모으는 중");
        // }

        // if (Input.GetButtonUp("Jump"))
        // {
        //     Debug.Log("슈퍼 점프!!");
        // }

        // if (Input.GetButton("Horizontal"))
        // {
        //     Debug.Log("횡 이동" + Input.GetAxisRaw("Horizontal"));
        // }

        // if (Input.GetButton("Vertical"))
        // {
        //     Debug.Log("종 이동" + Input.GetAxisRaw("Vertical"));
        // }





    }
}
