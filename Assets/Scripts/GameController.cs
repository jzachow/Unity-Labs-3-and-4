﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    public int Score = 0;
    public bool GameOver = true;
    public int NumberOfBalls = 0;
    public int MaximumBalls = 15;
    public Text ScoreText;
    public Button PlayAgainButton;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddBall", 1.5F, 1);
    }

    // Update is called once per frame
    void AddBall()
    {
        if (!GameOver)
        {
            Instantiate(OneBallPrefab);
            NumberOfBalls++;
            if (NumberOfBalls >= MaximumBalls)
            {
                GameOver = true;
                PlayAgainButton.gameObject.SetActive(true);
            }
        }        
    }

    public void ClickOnBall()
    {
        Score++;
        NumberOfBalls--;
    }

    public void StartGame()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("GameController"))
        {
            Destroy(ball);
        }
        PlayAgainButton.gameObject.SetActive(false);
        Score = 0;
        NumberOfBalls = 0;
        GameOver = false;
    }

    private void Update()
    {
        ScoreText.text = Score.ToString();
    }
}
