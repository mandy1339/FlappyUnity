using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScores : MonoBehaviour
{
    public Text scoreText;
    public Text bestScoreText;
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = GameManager.score.ToString();
        // bestScoreText.text = "tbd";
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (GameManager.score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", GameManager.score);
        }
        bestScoreText.text = PlayerPrefs.GetInt("BestScore").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        print("enabled");
        scoreText.text = GameManager.score.ToString();

    }
}
