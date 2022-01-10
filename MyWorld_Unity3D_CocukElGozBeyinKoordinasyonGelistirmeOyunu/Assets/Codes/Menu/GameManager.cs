using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //bool gamehasEnded = false;
    //public float restartdelay = 1f;


    /*
    public void EndGame()
    {
        if (gamehasEnded == false)
        {
            gamehasEnded = true;
            Debug.Log("GAMEOVER");

            Invoke("Restart", restartdelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
        */


    public GameObject gameoverUI;

    public GameObject nextlevelUI;

    bool gamehasEnded = false;
    public float restartdelay = 1f;
    public void EndGame()
    {
        if (gamehasEnded == false)
        {
            Time.timeScale = 0f;
            gameoverUI.SetActive(true);
            gamehasEnded = true;
            Debug.Log("GAMEOVER");

            Invoke("Restart", restartdelay);
        }
    }

    public void CompleteLevel()
    {
        if (gamehasEnded == false)
        {
            Time.timeScale = 0f;
            nextlevelUI.SetActive(true);
            gamehasEnded = true;
            Debug.Log("WİNNNNN");

            Invoke("NextLevel", restartdelay);
        }


       
       
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        nextlevelUI.SetActive(false);
        Time.timeScale = 1f;
        gamehasEnded = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameoverUI.SetActive(false);
        Time.timeScale = 1f;
        gamehasEnded = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
}
