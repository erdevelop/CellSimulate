using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public static Spawn Instance;

    [SerializeField] GameObject cellPrefab_0;
    [SerializeField] GameObject cellPrefab_1;
    [SerializeField] GameObject cellPrefab_2;
    [SerializeField] GameObject cellPrefab_3;

    float ekranMinMax = 16;

    public int cellCount;

    public GameObject cell_0;
    public GameObject cell_1;
    public GameObject cell_2;
    public GameObject cell_3;

    public int cellCount_0;
    public int cellCount_1;
    public int cellCount_2;
    public int cellCount_3;

    public Text statsText;
    public Text skoreText;

    public float skore_0;
    public float skore_1;
    public float skore_2;
    public float skore_3;

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
        Stats();
        Skore();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void Stats()
    {
        statsText.text = "Stats:\n\n" +
                         "Red: " + cellCount_0 + "\n" +
                         "Green: " + cellCount_1 + "\n" +
                         "Blue: " + cellCount_2 + "\n" +
                         "Yellow: " + cellCount_3 + "\n";
    }
    public void Skore()
    {
        skoreText.text = "Skore:\n\n" +
                         "Red: " + skore_0 + "\n" +
                         "Green: " + skore_1 + "\n" +
                         "Blue: " + skore_2 + "\n" +
                         "Yellow: " + skore_3 + "\n";
    }
    public void Spawner()
    {
        

        for (int i = 0; i < cellCount; i++)
        {
            int sizeChoosing = Random.Range(0, 4);

            switch (sizeChoosing)
            {
                case 0:
                    cell_0 = Instantiate(cellPrefab_0, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);

                    cellCount_0++;
                    break;
                case 1:
                    cell_1 = Instantiate(cellPrefab_1, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);

                    cellCount_1++;
                    break;
                case 2:
                    cell_2 = Instantiate(cellPrefab_2, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);

                    cellCount_2++;
                    break;
                case 3: 
                    cell_3 = Instantiate(cellPrefab_3, new Vector3(Random.Range(-ekranMinMax, ekranMinMax), 2, Random.Range(-ekranMinMax, ekranMinMax)), Quaternion.identity);

                    cellCount_3++;
                    break;
                default:
                    break;
            }
        }
        Stats();
    }
}
