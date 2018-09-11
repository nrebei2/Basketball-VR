using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    public float Bouncibility = 1.1f;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Plane")
        {
            Vector3 v = rb.velocity;
            v.y = collision.relativeVelocity.y / Bouncibility;
            rb.velocity = v;
        }
        else if (collision.transform.gameObject.name == "basketball hoop" || collision.transform.gameObject.tag == "Wall")
        {
            Vector3 v = rb.velocity;
            v.y = collision.relativeVelocity.y / Bouncibility / 2;
            v.z = -collision.relativeVelocity.z / Bouncibility / 3;
            v.x = collision.relativeVelocity.x / Bouncibility;
            rb.velocity = v;
        }
        else
        {
            Vector3 v = rb.velocity;
            v.y = collision.relativeVelocity.y / Bouncibility;
            v.z = collision.relativeVelocity.z / Bouncibility / 4;
            rb.velocity = v;
        }
    }
}
