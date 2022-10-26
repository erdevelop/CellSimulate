using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("program is started..");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButton()
    {
        Spawn.Instance.Spawner();
    }
}
