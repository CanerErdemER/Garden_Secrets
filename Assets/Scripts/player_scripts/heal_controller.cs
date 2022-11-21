using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal_controller : MonoBehaviour
{
    public int maxhealth;
    public int health;
   
    Rigidbody2D rb;
    public bool deathquestion=false;

    UI_controller ui_Controller;
    
    private void Awake()
    {
        ui_Controller = Object.FindObjectOfType<UI_controller>();  
        

    }

    public void Start()
    {
        health = maxhealth;
    }
    
    public void TakeDamage()
    {
        health = health - 1;

        ui_Controller.healtUIhupdateFNC();
    }

   

}
