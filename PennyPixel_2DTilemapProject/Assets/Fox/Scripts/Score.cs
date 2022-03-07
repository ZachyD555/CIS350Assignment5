/*
 * Zach Daly
 * Assignment 5A
 * Manages Score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Attach to ScoreText text object
public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        // Set textbox reference in Unity
        // Then set the score to start at 0
        scoreText.text = "Score: 0";
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
