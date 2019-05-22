using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float fallMultiplier = 3.2f;
    public float lowJumpMultiplier = 1.8f;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
           
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (transform.position.y <= 1.05f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 150);
            }
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;

        }
        
    }

}

