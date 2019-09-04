using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public AudioSource CoinFX;
    

    void OnTriggerEnter(Collider other)
    {
        CoinFX.Play();
        CoinScoringSystem.theScore += 1;
        Destroy(gameObject);
    }
}
