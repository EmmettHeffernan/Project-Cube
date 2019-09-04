﻿
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour{

    // defining player movement script as var
    public PlayerMovement movement;
    public AudioClip ImpactFX;

    public GameObject crackedVersion;

    private void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = ImpactFX;
    }

    // code runs on collision
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Collision info calls for a tag being obstacle and sets if statement

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            spawnCracked();
            FindObjectOfType<GameManager>().EndGame();
            GetComponent<AudioSource>().Play();
        }

        if (collisionInfo.collider.tag == "DoublePassObst")
        {
            movement.enabled = false;
            spawnCracked();
            FindObjectOfType<GameManager>().EndGame();
            GetComponent<AudioSource>().Play();
        }

    }

    void spawnCracked()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Rigidbody>().drag = 99999999999999;
        Instantiate(crackedVersion, transform.position, new Quaternion(0f, 0f, 0f, 0f));
    }

}