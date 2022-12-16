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
    RedBossController redBossController;
    

    private void Awake()
    {
        player_Controller = Object.FindObjectOfType<player_controller>();
        mushow_Scripts = Object.FindObjectOfType<Mushow_controller>();
        pholox_Pepper_Controller = Object.FindObjectOfType<Pholox_pepper_controller>();
        redBossController = Object.FindObjectOfType<RedBossController>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag) 
        {
            case ("mushow"):
                {
                    mushow_Scripts.leftTarget.parent = mushow_Scripts.transform;
                    mushow_Scripts.rightTarget.parent = mushow_Scripts.transform;
                    Destroy(collision.gameObject);

                    player_Controller.enemytouchjumpFNC();
                    float spawnrange = Random.Range(0, 100);

                    if (spawnrange <= waterdropchance)
                    {
                        Instantiate(waterdropobject, collision.transform.position, collision.transform.rotation);
                    }
                    break;
                }
            
            case ("pepper"):
                {
                    pholox_Pepper_Controller.lefttarget.parent = pholox_Pepper_Controller.transform;
                    pholox_Pepper_Controller.righttarget.parent = pholox_Pepper_Controller.transform;
                    Destroy(collision.gameObject);
                    player_Controller.enemytouchjumpFNC();
                    break;
                }
            case ("Redboss"):
                {
                    redBossController.TakeDamageFNC();
                    player_Controller.BossTouchJumpFNC();
                    break;
                }
                
        }
    }
   
}
