using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crasherbox_controller : MonoBehaviour
{
    player_controller player_Controller;
    public float waterdropchance;
    public GameObject waterdropobject;
    Mushow_controller mushow_Scripts;
    

    private void Awake()
    {
        player_Controller = Object.FindObjectOfType<player_controller>();
        mushow_Scripts = Object.FindObjectOfType<Mushow_controller>();
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
    }
}
