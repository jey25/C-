using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable()
    {
        Debug.Log("플레이어가 로그인 했습니다.");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate()
    {
        Debug.Log("이동~");
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("몬스터 사냥~");
    }

    void LateUpdate()
    {
        Debug.Log("경험치 획득!");
    }

    void OnDisable()
    {
        Debug.Log("플레이어가 로그 아웃 했습니다.");
    }

    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
