using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_cell_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cell_0" || collision.gameObject.tag == "cell_1" ||
            collision.gameObject.tag == "cell_2" || collision.gameObject.tag == "cell_3")
        {
            if (collision.gameObject.transform.localScale.x <= gameObject.transform.localScale.x)
            {
                gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
                Spawn.Instance.skore_3++;
                switch (collision.gameObject.tag)
                {
                    case "cell_0": Spawn.Instance.cellCount_0--; Destroy(collision.gameObject); break;
                    case "cell_1": Spawn.Instance.cellCount_1--; Destroy(collision.gameObject); break;
                    case "cell_2": Spawn.Instance.cellCount_2--; Destroy(collision.gameObject); break;
                    case "cell_3": Spawn.Instance.cellCount_3--; Destroy(collision.gameObject); break;
                    default:
                        break;
                }
            }
        }
        Spawn.Instance.Stats();
        Spawn.Instance.Skore();
    }
}
