using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    bool movings;
    float speed;
    float length;

    int choosing;

    public bool Movings
    {
        get
        {
            return movings;
        }
        set
        {
            movings = value;
        }
    }
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
    public float Length
    {
        get
        {
            return length;
        }
        set
        {
            length = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = 4.0f;
        length = 8.0f;
        movings = true;
        choosing = Random.Range(0, 10);

        transform.position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(movings)
        {
            float pingPongX = Mathf.PingPong(Time.time * speed, length);
            float pingPongZ = Mathf.PingPong(Time.time * speed, length);

            if(choosing < 5)
            {
                Vector3 pingPong = new Vector3(pingPongX, transform.position.y, transform.position.z);
                transform.position = pingPong;
            }
            if(choosing > 5)
            {
                Vector3 pingPong = new Vector3(transform.position.x, transform.position.y, pingPongZ);
                transform.position = pingPong;
            }
        }
        
    }
}
