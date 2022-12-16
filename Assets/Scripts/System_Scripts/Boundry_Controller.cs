using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boundry_Controller : MonoBehaviour
{
    gamemanager gamemanager;
    
    private void Awake()
    {
        gamemanager = FindObjectOfType<gamemanager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gamemanager.GameOverFNC();
        }
    }

}
