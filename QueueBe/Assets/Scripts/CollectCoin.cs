using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public AudioSource CoinFX;


    void OnTriggerEnter(Collider collider)
    {
        // only collects coin if player hits coin
        if (collider.name == "Player")
        {
            CoinFX.Play();
            CoinScoringSystem.theScore += 1;
            Destroy(gameObject);
        }
    }
}
