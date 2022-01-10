using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeriSayim : MonoBehaviour
{
    public GameManager gameManager;
   
    public TextMeshProUGUI geriSayimText;

    public float geriSayim,beklemesuresi;
    private int tetikleyici;
 
    public GameObject yer1, yer2, yer3, yer4,plane1,plane2,plane3,plane4;

    void Start()
    {
        geriSayim = 4.0f;
        geriSayimText.text = "" + (int)geriSayim;
        tetikleyici = 0;
        beklemesuresi = 4.0f;
       

        yer1.gameObject.SetActive(false);
        yer2.gameObject.SetActive(false);
        yer3.gameObject.SetActive(false);
        yer4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayim > 0f)
        {
            geriSayim -= Time.deltaTime;
            geriSayimText.text = "" + (int)geriSayim;
        }
        else
        {
            geriSayimText.gameObject.SetActive(false);

            if (tetikleyici == 0)
            {
                yer1.gameObject.SetActive(true);
            }
            if (tetikleyici == 1)
            {
                plane1.gameObject.SetActive(false);
                yer2.gameObject.SetActive(true);
            } 
            if (tetikleyici == 2)
            {
                plane2.gameObject.SetActive(false);
                yer3.gameObject.SetActive(true);
            } 
            if (tetikleyici == 3)
            {
                plane3.gameObject.SetActive(false);
                yer4.gameObject.SetActive(true);
            }
            if (tetikleyici == 4)
            {
                plane4.gameObject.SetActive(false);
                //
                if (beklemesuresi > 0f)
                {
                    beklemesuresi -= Time.deltaTime;
                }
                else
                {
                    gameManager.CompleteLevel();
                }
            }


        }
    }

    public void Player1Tetikleyici()
    {
        if (tetikleyici==0)
        {
            tetikleyici = 1;
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    } 
    public void Player2Tetikleyici()
    {
        if (tetikleyici==1)
        {
            tetikleyici = 2;
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    } 
    public void Player3Tetikleyici()
    {
        if (tetikleyici==2)
        {
            tetikleyici = 3;
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    } 
    public void Player4Tetikleyici()
    {
        if (tetikleyici==3)
        {
            tetikleyici = 4;
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
