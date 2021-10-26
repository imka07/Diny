using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScor : MonoBehaviour
{

    public Text scoreText;
    void Start()
    {
        

        float coins = PlayerPrefs.GetFloat("score");
        float recordScore = PlayerPrefs.GetFloat("recordScore");
        scoreText.text = coins.ToString("0");

        if (coins > recordScore)
        {
            recordScore = coins;
            PlayerPrefs.SetFloat("recordScore", recordScore);
            scoreText.text = recordScore.ToString("0");
        }
        else
        {
            scoreText.text = recordScore.ToString("0");

        }




    }


}
