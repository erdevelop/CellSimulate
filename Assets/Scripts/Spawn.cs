using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static Spawn Instance;

    //[SerializeField] public List<GameObject> cellList = new List<GameObject>();

    [SerializeField] GameObject cellPrefab_0;
    [SerializeField] GameObject cellPrefab_1;
    [SerializeField] GameObject cellPrefab_2;
    [SerializeField] GameObject cellPrefab_3;

    float ekranMinMax = 16;

    int cellCount = 128;

    public GameObject cell_0;
    public GameObject cell_1;
    public GameObject cell_2;
    public GameObject cell_3;

    public GameObject cell;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public GameObject Spawner()
    {

        for (int i = 0; i < cellCount; i++)
        {

            int sizeChoosing = Random.Range(0, 4);

            switch (sizeChoosing)
            {
                case 0:
                    cell_0 = Instantiate(cellPrefab_0, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);
                    cell = cell_0;
                    break;
                case 1:
                    cell_1 = Instantiate(cellPrefab_1, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);
                    cell = cell_1;
                    break;
                case 2:
                    cell_2 = Instantiate(cellPrefab_2, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);
                    cell = cell_2;
                    break;
                case 3: 
                    cell_3 = Instantiate(cellPrefab_3, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);
                    cell = cell_3;
                    break;
                default:
                    break;
            }
        }
        return cell;

    }
    
    
    

}
