using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pholox_pepper_controller : MonoBehaviour
{
    public float movement_speed;
    public Transform lefttarget, righttarget;
    bool isdirectionright;
    Rigidbody2D rb;
    public SpriteRenderer sr;


    Animator anim;
    public float movementtime, waitingtime;
    float Movementcounter, waitingcounter;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        lefttarget.parent = null;
        righttarget.parent = null;
        isdirectionright = true;
        Movementcounter = movementtime;
    }

    void Update()
    {
        movementFNC();
    }
    public void movementFNC()
    {
        if (Movementcounter >= 0)
        {
            Movementcounter -= Time.deltaTime;
            if (isdirectionright)
            {
                rb.velocity = new Vector2(movement_speed, rb.velocity.y);
                sr.flipX = true;
                if (transform.position.x > righttarget.position.x)
                {
                    isdirectionright = false;
                }
            }
            else
            {
                rb.velocity = new Vector2(-movement_speed, rb.velocity.y);
                sr.flipX = false;
                if (transform.position.x < lefttarget.position.x)
                {
                    isdirectionright = true;
                }
            }
            if (Movementcounter <= 0)
            {
                waitingcounter = Random.Range(2, 4);
            }
            anim.SetBool("movement_speed", true);

        }
        else if (waitingcounter >= 0)
        {
            waitingcounter -= Time.deltaTime;
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (waitingcounter <= 0)
            {
                Movementcounter = Random.Range(5, 10);
            }
            anim.SetBool("movement_speed", false);
        }
        

    }

}
