/*
 * Zach Daly
 * Assignment 5B
 * Triggers end of game text
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameTrigger : MonoBehaviour
{
    public Text endMsg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endMsg.text = "You Won!!!\nGood Job!!!";
        }
    }
}
