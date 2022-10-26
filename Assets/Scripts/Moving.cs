using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    bool movings;

    float speed;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movings = true;
        speed = 1f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
        
    public void Move()
    {
        if (movings)
        {
            rb.AddForce(Speedy(-speed, speed), 0, Speedy(-speed, speed), ForceMode.VelocityChange); 
        }
    }
    public float Speedy(float spMin, float spMax)
    {
        return Random.Range(spMin, spMax);
    }
    
}