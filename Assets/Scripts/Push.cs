using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Push : MonoBehaviour
{
    bool movings;
    float speed;
    float speedMax;

    [SerializeField] Rigidbody rb;

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
    public float SpeedMax
    {
        get
        {
            return speedMax;
        }
        set
        {
            speedMax = value;
        }
    }
    
    void Start()
    {
        rb = GetComponent<Spawn>().cellPrefab.GetComponent<Rigidbody>();
        Movings = true;
        SpeedMax = 10.0f;
    }
    // Update is called once per frame
    void PushButton()
    {
        Move();


    }
    public void Move()
    {
        if (Movings)
        {
            int choosing = Random.Range(0, 4);

            if (choosing == 0)
            {
                Speed = Random.Range(1.0f, SpeedMax);
                rb.AddForce(Speed, transform.position.y, transform.position.z, ForceMode.Impulse);
                Movings = false;
            }
            else if (choosing == 1)
            {
                Speed = Random.Range(1.0f, SpeedMax);
                rb.AddForce(transform.position.x, transform.position.y, Speed, ForceMode.Impulse);
                Movings = false;
            }
            else if (choosing == 2)
            {
                Speed = Random.Range(1.0f, SpeedMax);
                rb.AddForce(transform.position.x, transform.position.y, -Speed, ForceMode.Impulse);
                Movings = false;
            }
            else if (choosing == 3)
            {
                Speed = Random.Range(1.0f, SpeedMax);
                rb.AddForce(-Speed, transform.position.y, transform.position.z, ForceMode.Impulse);
                Movings = false;
            }
        }
    }

}
