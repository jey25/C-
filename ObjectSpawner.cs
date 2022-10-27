using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;
    private void Awake()
    {
        // Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        // Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity);

        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);
    }
}
