using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles_controller : MonoBehaviour
{
    gamemanager gm;
    [SerializeField]
    bool isitstar;
    bool isitcollected;
    [SerializeField]
    bool isitwaterdrop;
    UI_controller uI_Controller;
    heal_controller heal_Controller;

    private void Awake()
    {
        uI_Controller = Object.FindObjectOfType<UI_controller>();
        gm= Object.FindObjectOfType<gamemanager>();
        heal_Controller = Object.FindObjectOfType<heal_controller>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&!isitcollected&&isitstar)
        {
            
            if (gm.collectedstarcount < 5)
            {
                gm.collectedstarcount++;
                isitcollected = true;
                Destroy(gameObject);
            }
            uI_Controller.starpowerUpdateFNC();

        }
        else if (collision.CompareTag("Player") && !isitcollected && isitwaterdrop)
        {
            if (heal_Controller.health < 6)
            {
                heal_Controller.health++;
                isitcollected=true;
                Destroy(gameObject);
            }
            uI_Controller.healtUIhupdateFNC();

        }
    }


}
