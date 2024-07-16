using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Text highScoreText;
    public int highScore;
    // public AudioSource dingMP3;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        // dingMP3.Play();
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);

        gameOverScreen.SetActive(true);

        if(playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
}
