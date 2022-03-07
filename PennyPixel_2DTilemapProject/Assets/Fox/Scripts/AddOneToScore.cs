/*
 * Zach Daly
 * Assignment 5A
 * Adds one to score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach to gem
public class AddOneToScore : MonoBehaviour
{
    private Score displayScoreScript;
    void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        displayScoreScript.score++;
    }
}
