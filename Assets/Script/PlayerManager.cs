using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerManager : MonoBehaviour
{

     public static bool gameOver;
     public GameObject gameOverPanel;

     public static int numberOfCoins;
     //public int score = 0;
     public Text coinsText;



    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        numberOfCoins = 0;
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;

            gameOverPanel.SetActive(true);
        }

        coinsText.text = "Coins:" + numberOfCoins;


    }
}
