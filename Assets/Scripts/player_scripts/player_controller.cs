using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    [SerializeField]
    public float move_speed;

    [SerializeField]
    public float jump_power;

    bool touch_floor;
    public Transform floor_check_point;
    public LayerMask floor_layer;

    Rigidbody2D rb;
    Animator anim;
    Collider2D cllidr;
    gamemanager gamemanager;
    heal_controller healthcont;

    public float recoil, recoilTime;
    float recoilcounter;
    bool directoryrihgt;




    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        cllidr= GetComponent<Collider2D>();

        gamemanager = Object.FindObjectOfType<gamemanager>(gamemanager);
        healthcont = Object.FindObjectOfType<heal_controller>(healthcont);


    }
    private void Update()
    {
        if (recoilcounter <= 0)
        {
            if (healthcont.deathquestion == false)
            {
                movementFNC();
                jumpFNC();
                change_directoryFNC();
            }
            else
            {
                deathFNC();
            }
            
        }
        else
        {
            recoilcounter -= Time.deltaTime;
            if (directoryrihgt)
            {
                rb.velocity = new Vector2(-recoil, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(recoil, rb.velocity.y);
            }
          
        }
        anim.SetFloat("speed", Mathf.Abs(rb.velocity.x));
        anim.SetBool("onthefloor", touch_floor);
        deathFNC();

    }
    void movementFNC()
    {
        float h = Input.GetAxis("Horizontal");
        float speed = h * move_speed;

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    void jumpFNC()
    {
        touch_floor = Physics2D.OverlapCircle(floor_check_point.position, 0.2f, floor_layer);

        if (Input.GetButtonDown("Jump"))
        {
            if (touch_floor)
            {
                rb.velocity = new Vector2(rb.velocity.x, jump_power);
            }
        }
        anim.SetFloat("speed",Mathf.Abs(rb.velocity.x));
        anim.SetBool("onthefloor", touch_floor);
    }  

    void change_directoryFNC()
    {
        Vector2 jokerScale=transform.localScale;
        if(rb.velocity.x > 0)
        {
            jokerScale.x = 4.147688f;
            directoryrihgt = true;
        }
        
        else if(rb.velocity.x < 0)
        {
            jokerScale.x = -4.147688f;
            directoryrihgt = false;
        }
        transform.localScale = jokerScale;
    }
    
    void deathFNC()
    {
        
        if (healthcont.health <= 0)
        {
            healthcont.deathquestion = true;
            anim.SetBool("death", healthcont.deathquestion);
            rb.velocity = new Vector2(0, 0);
            
        }
        


    }

    public void recoilFNC()
    {
        recoilcounter = recoilTime;
        rb.velocity = new Vector2(0, rb.velocity.y);
        if (healthcont.health >= 1) 
        anim.SetTrigger("damage");
    }
}
