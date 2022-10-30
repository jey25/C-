using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    Vector3 target = new Vector3(8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //1. MoveTowards 목표지점을 향해 이동
        // transform.position = Vector3.MoveTowards(transform.position, target, 1f);


        //2. SmoothDamp 목표지점을 향해 스무쓰하게 이동, 값이 적을수록 빠르게 이동
        // Vector3 velo = Vector3.zero;

        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);


        //3. Lerp MoveTowards 와 비슷, 값이 적을수록 느리게 이동
        // transform.position = Vector3.Lerp(transform.position, target, 0.05f);


        // 4. SLerp 목표 지점을 향해 포물선을 그리며 이동
        // transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
}
