using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // This is the reference to the Rigidbody componenet called rb
    public Rigidbody rb;

    public float forwardForce = 800f;
    public float sidewaysForce = 500f;
    // We marked this as FixedUpdate because we are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) // Move right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // Move left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
