using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crasherbox_controller : MonoBehaviour
{
    player_controller player_Controller;
    public float waterdropchance;
    public GameObject waterdropobject;

    private void Awake()
    {
        player_Controller = Object.FindObjectOfType<player_controller>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mushow"))
        {
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
