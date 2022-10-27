using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;
    private void Awake()
    {
        Instantiate(boxPrefab);
        Instantiate(boxPrefab);
    }
}
