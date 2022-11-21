using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal_controller : MonoBehaviour
{
    public int maxhealth;
    public int health;
   
    Rigidbody2D rb;
    public bool deathquestion=false;
    
    private void Awake()
    {
      
        

    }

    public void Start()
    {
        health = maxhealth;
    }
    
    public void TakeDamage()
    {
        health = health - 5;
        
    }

   

}
