using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Vector3 startpoint;
    public float maxVelocity=300;





    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime ,0, 0,ForceMode.VelocityChange);
        }

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            transform.position = startpoint;

            
        }
        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = (Vector2)Vector3.ClampMagnitude((Vector3)rb.velocity, maxVelocity);
        }

    }
}
