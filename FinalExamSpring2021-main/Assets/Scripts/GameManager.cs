using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static float time = 30;
    public static int lives;

    public Text LivesDisplay;
    public Text PointsDisplay;
    public Text PlayerName;
    public Text Timer;
    void Start()
    {
        score = 0;
        Time.timeScale = 1f;
        lives = Livesdropdown.lives;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName.text = "Currently Playing: " + SendText.theName;
        LivesDisplay.text = "Lives: " + lives.ToString();
        PointsDisplay.text = "Score: " + score.ToString();
    }

    void FixedUpdate()
    {
        time -= Time.deltaTime;
        Timer.text = "Time Remaining: " + Mathf.FloorToInt(time).ToString();

        if(time <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void IncreaseScore()
    {
        score++;
    }
    public void DecreaseScore()
    {
        score--;
    }
    public void IncreaseLives()
    {
        lives++;
    }
    public void DecreaseLives()
    {
        lives--;
    }
}
