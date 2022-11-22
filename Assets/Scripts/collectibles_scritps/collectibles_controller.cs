using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles_controller : MonoBehaviour
{
    gamemanager gm;
    [SerializeField]
    bool isitstar;
    bool isitcollected;

    private void Awake()
    {
       gm= Object.FindObjectOfType<gamemanager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&!isitcollected&&isitstar)
        {
            gm.collectedstarcount++;
            isitcollected= true;
            Destroy(gameObject);


        }


    }
}
