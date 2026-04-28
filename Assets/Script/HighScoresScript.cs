using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScoresScript : MonoBehaviour
{

    public TMP_Text Highscoretext;
    
    // Start is called before the first frame update
    void Start()
    {
        Highscoretext.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

       // scoreText.text = BallController.score.ToString();
        if (BallController.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", BallController.score);
            //Highscoretext.text = BallController.score.ToString();
        }
        


    }
}
