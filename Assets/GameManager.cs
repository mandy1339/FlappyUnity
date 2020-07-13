using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text txt;
    public static int score;
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = score.ToString();
        print("updated score to " + score.ToString());
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
    }

    public void PlayGameAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
