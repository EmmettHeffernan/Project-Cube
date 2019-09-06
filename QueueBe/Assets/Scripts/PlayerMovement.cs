
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float minBreakVelocity = 5f;

    public bool freezeRotation = true;

    void Start()
    {
        // makes the player's rotation unchanging to avoid rotation drift
        // (not currently active)
        rb.freezeRotation = freezeRotation;
    }

    // Update is called once per frame
    // FixedUpdate for phsysics stuff
    void FixedUpdate()
    {
        // Adding a forward force (if not breaking, or if going too slow)
        // *Time.deltaTime for frame rate optimization
        if (!Input.GetKey("s") || rb.velocity.z < minBreakVelocity)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
