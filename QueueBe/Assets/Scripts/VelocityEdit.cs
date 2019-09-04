using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityEdit : MonoBehaviour
{

    // the desired velocity of the cracked player pieces at time of instantiation
    public Vector3 crumbleVelocity;

    void Start() {
        gameObject.GetComponent<Rigidbody>().velocity = crumbleVelocity;
    }

}
