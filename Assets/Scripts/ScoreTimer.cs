using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public int score;
    public float timer;

    private bool gameOver = false;
    public GameObject winPanel;
    public TextMeshProUGUI finalScore;
    public bool isEndless;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isEndless)
        {
            if (timer < 0 && !gameOver) GameOver();
            timer -= Time.deltaTime;
            UpdateTimer(timer);
        }

    }
    public void UpdateTimer(float a)
    {
        float minutes = Mathf.FloorToInt(a / 60);
        float seconds = Mathf.FloorToInt(a % 60);
        if(seconds < 10) timerText.text = minutes + ":0" + seconds;
        else timerText.text = minutes + ":" + seconds;
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = "" + score;
    }
    public void GameOver()
    {
        gameOver = true;
        winPanel.SetActive(true);
        finalScore.text = "" + score;
    }

    public void BackToMenu()
    {
        score = 0;
        scoreText.text = "" + score;
        timer = 300;
        winPanel.SetActive(false);
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenEndlessMenu()
    {
        winPanel.SetActive(true);
        finalScore.text = "" + score;
    }
    public void CloseEndlessMenu()
    {
        winPanel.SetActive(false);
    }
}
