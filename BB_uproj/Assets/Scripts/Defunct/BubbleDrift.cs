using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDrift : MonoBehaviour
{
    public float thrust;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        thrust = 0.5f; 
   
    }

   
    void Update ()
    {
       // rb.AddRelativeForce(transform.right * thrust);
       // WaitForSeconds(2f);
       // rb.AddRelativeForce(-transform.right * thrust);

    }

    private void WaitForSeconds(float v)
    {
        throw new NotImplementedException();
    }
}
