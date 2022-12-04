using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballscripts : MonoBehaviour
{
    heal_controller heal_Controller;

    public float speed;

    private void Awake()
    {
       
        heal_Controller=Object.FindObjectOfType<heal_controller>(); 
    }
    void Update()
    {
        transform.position += new Vector3(-speed *transform.localScale.x *Time.deltaTime, 0f,0f);
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        switch (collision.tag)
        {
            case ("Player"):
                heal_Controller.TakeDamage();
                Destroy(gameObject);
                break;
            default:
                Destroy(gameObject);
                break;

        }
            
        
    }
}
