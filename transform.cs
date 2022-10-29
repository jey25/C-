using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Vector3 vec = new Vector3(5, 5, 5);
        // transform.Translate(vec);
    }


    //키보드 입력을 통한 오브젝트 이동
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0);
        transform.Translate(vec);
    }

}
