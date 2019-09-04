using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody rb;

    public float upwardsForce = 15f;

    public void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0);

        }
    }

}
