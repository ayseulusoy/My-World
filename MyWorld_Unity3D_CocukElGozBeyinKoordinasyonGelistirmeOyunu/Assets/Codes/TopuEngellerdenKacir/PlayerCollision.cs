using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject gameoverUI;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "engel")
        {
            gameoverUI.SetActive(true);
            FindObjectOfType<GameManager>().EndGame();


        }
        
        
    }
}
