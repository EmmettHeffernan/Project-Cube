using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    Vector3 pos1;
    Vector3 pos2;
    public float speed = 0.5f;
    public float startDelay = 0;

    void Start()
    {
        pos1 = new Vector3(-6, 1, transform.position.z);
        pos2 = new Vector3(6, 1, transform.position.z);
    }

    void FixedUpdate()
    {
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong((Time.time - startDelay) * speed, 1.0f));
    }
}

