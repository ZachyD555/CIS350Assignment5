/*
 * Zach Daly
 * Assignment 5A
 * Lets the user know when they finished the level
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLineMessage : MonoBehaviour
{
    //Set ref in inpector
    public Text winText;
    private bool hitFinish = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && hitFinish == true)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winText.text = ("You Win!!\n Press (R) To Try Again!!");
        hitFinish = true;
    }
}
