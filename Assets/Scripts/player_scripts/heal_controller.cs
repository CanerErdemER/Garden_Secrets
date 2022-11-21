using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal_controller : MonoBehaviour
{
    public int maxhealth;
    public int health;
   
    Rigidbody2D rb;
    public bool deathquestion=false;
    SpriteRenderer spriteRenderer;

    UI_controller ui_Controller;

    player_controller player_Controller;
    
    private void Awake()
    {
        ui_Controller = Object.FindObjectOfType<UI_controller>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        player_Controller = Object.FindObjectOfType<player_controller>();

    }

    public void Start()
    {
        health = maxhealth;
    }
    
    public void TakeDamage()
    {
        health = health - 1;
        spriteRenderer.color = new Color(255, spriteRenderer.color.g, spriteRenderer.color.b, spriteRenderer.color.a);
        ui_Controller.healtUIhupdateFNC();
        player_Controller.recoilFNC();

        
    }

   

}
