﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
  
    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime); 
    }
}