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
            if (collision.gameObject.transform.localScale.x >= gameObject.transform.localScale.x)
            {
                Destroy(gameObject, 0.1f);
            }
            else if (collision.gameObject.transform.localScale.x >= 3f || gameObject.transform.localScale.x >= 3f)
            {
                Destroy(gameObject, 0.1f);
            }
            else
            {
                gameObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            }
        }
    }
}
