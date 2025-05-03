using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class ScoreIncrement : MonoBehaviour
{
    public int PlayerScore;
    public static int HighScore;
    public GameObject gameoverscreen;
    public GameObject play;
    public GameObject pause;
    public Text ScoreText;
    public Text HighScoreText;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoretoadd)
    {
        PlayerScore += scoretoadd;
        ScoreText.text = PlayerScore.ToString();
    }

    public void DisplayHighScore()
    {
        if (HighScore < PlayerScore) HighScore = PlayerScore;
        HighScoreText.text = "High Score: " + HighScore.ToString();
        Debug.Log(HighScore);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Game_Over()
    {
        gameoverscreen.SetActive(true);
        DisplayHighScore();
        Time.timeScale = 0f;
    }


    public void PauseGame()
    {
        bool Paused = true;
        if(Paused == true){    
            Time.timeScale = 0f;
            Paused = false;
            play.SetActive(true);
            pause.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            Paused = true;
            pause.SetActive(true);
            play.SetActive(false);
        }
    }
}
