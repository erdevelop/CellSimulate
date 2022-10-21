using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] List<GameObject> cellList = new List<GameObject>();

    [SerializeField] public GameObject cellPrefab;

    float ekranMinMax = 16;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            cellList.Add(cellPrefab);
        }

        for (int i = 0; i < cellList.Count; i++)
        {
            Instantiate(cellList[i], new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 5, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);
        }
        Debug.Log("cell count: " + cellList.Count);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
