using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crasherbox_controller : MonoBehaviour
{
    player_controller player_Controller;
    public float waterdropchance;
    public GameObject waterdropobject;
    Mushow_controller mushow_Scripts;
    Pholox_pepper_controller pholox_Pepper_Controller;
    

    private void Awake()
    {
        player_Controller = Object.FindObjectOfType<player_controller>();
        mushow_Scripts = Object.FindObjectOfType<Mushow_controller>();
        pholox_Pepper_Controller = Object.FindObjectOfType<Pholox_pepper_controller>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mushow"))
        {
            mushow_Scripts.leftTarget.parent = mushow_Scripts.transform;
            mushow_Scripts.rightTarget.parent = mushow_Scripts.transform;
            Destroy(collision.gameObject);

            player_Controller.enemytouchjump();
            float spawnrange = Random.Range(0, 100);

            if (spawnrange <= waterdropchance)
            {
                Instantiate(waterdropobject, collision.transform.position, collision.transform.rotation);
            }

        }
        else if (collision.CompareTag("pepper"))
        {
            pholox_Pepper_Controller.lefttarget.parent = pholox_Pepper_Controller.transform;
            pholox_Pepper_Controller.righttarget.parent = pholox_Pepper_Controller.transform;
            Destroy(collision.gameObject);
        }
    }
   
}
