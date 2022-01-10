﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopAlgila : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            //Destroy(other.gameObject);
            gameManager.CompleteLevel();
        }
    }
}
