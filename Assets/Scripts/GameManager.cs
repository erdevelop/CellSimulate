using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public InputField cellSpawnInputField;
    public int cellCounter;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("program is started..");
        cellSpawnInputField.text = "4";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButton()
    {
        Spawn.Instance.Spawner();
    }
    public void CellCountInput()
    {
        cellCounter = int.Parse(cellSpawnInputField.text);
        Spawn.Instance.cellCount = cellCounter;
    }
    public void ResetButton()
    {
        SceneManager.LoadScene(0);
    }
}
