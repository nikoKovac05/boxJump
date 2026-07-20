using UnityEngine;
using TMPro;
using Unity.VisualScripting.AssemblyQualifiedNameParser;
using System;
public class score : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    
    private int HighScore = 0;
    private int highScoreTa = 0;

    public bool isTa = false;

    //za conine
    private int nextCoin = -10;
    private int coins;
    
    void Start()
    {
        coins = PlayerPrefs.GetInt("coins");
        if (isTa)
        {
            setUpHighScore("highScoreTa");
        }
        else
        {
            setUpHighScore("highScore");
        }
        
    }
    private void setUpHighScore(string t)
    {
        HighScore = PlayerPrefs.GetInt(t);
        highScoreText.text = "high score: " + HighScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTa)
        {
            scoreText.text = "score " + Convert.ToInt32(gameObject.transform.position.y * -1);

            if(gameObject.transform.position.y <= nextCoin)
            {
                nextCoin -= 10;
                coins++;
                PlayerPrefs.SetInt("coins", coins);
            }

            if (gameObject.transform.position.y > HighScore)
            {
                HighScore = Convert.ToInt32(gameObject.transform.position.y) * -1;
                PlayerPrefs.SetInt("highScore", HighScore);
                highScoreText.text = "high score:" + HighScore;
            }
        }
        else
        {
            scoreText.text = "score " + Convert.ToInt32(gameObject.transform.position.y);

            if (gameObject.transform.position.y  > highScoreTa)
            {
                highScoreTa = Convert.ToInt32(gameObject.transform.position.y);
                PlayerPrefs.SetInt("highScoreTa", highScoreTa);
                highScoreText.text = "high score:" + highScoreTa;
            }
        }
    }
}
