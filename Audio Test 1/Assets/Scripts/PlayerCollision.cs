
using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour{

    // defining player movement script as var
    public PlayerMovement movement;
    public AudioClip ImpactFX;

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
            FindObjectOfType<GameManager>().EndGame();
            GetComponent<AudioSource>().Play();
        }

        if (collisionInfo.collider.tag == "DoublePassObst")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            GetComponent<AudioSource>().Play();
        }


    }


}
