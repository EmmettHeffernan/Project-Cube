using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityEdit : MonoBehaviour
{

    public Vector3 crumbleVelocity;


    void Start() {
        gameObject.GetComponent<Rigidbody>().velocity = crumbleVelocity;
    }

}
