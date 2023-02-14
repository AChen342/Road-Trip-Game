using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 15000f;
    public float sidewaysForce = 60f;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics
    void FixedUpdate()
    {
        // Relative to player's computer framerate
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Left and right movement
        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    
    }
}
