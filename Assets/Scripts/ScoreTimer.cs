using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public int score;
    public float timer;

    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        UpdateTimer(timer);

    }
    public void UpdateTimer(float a)
    {
        float minutes = Mathf.FloorToInt(a / 60);
        float seconds = Mathf.FloorToInt(a % 60);
        timerText.text = minutes + ":" + seconds;
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = "" + score;
    }
}
