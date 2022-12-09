using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag_Controller : MonoBehaviour
{
    gamemanager gamemanager;

    private void Awake()
    {
     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            gamemanager.instance.FinishScene();
        } 
    }
    
}
