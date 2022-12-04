using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBossController : MonoBehaviour
{
    public enum RedBossSituation { Hit,TakeDamage,Move};
    public RedBossSituation CurrentSituation;

    [SerializeField]
    Transform RedBoss;
    [Header("Movement")]
    public float movement_speed;
    public Transform lefttarget, righttarget;
    bool isdirectionright;
    Rigidbody2D rb;
    public SpriteRenderer sr;
    [Header("Hit")]
    public GameObject FireBall;
    public Transform FireBallCenter;
    public float FireBallThrowTime;
    float FireBallThrowCounter;
    [Header("Damage")]
    public float TakeDamageTime;
    float TakeDamageCounter;


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

        CurrentSituation = RedBossSituation.Hit;
    }

    void Update()
    {
        
        switch (CurrentSituation)
        {
            case RedBossSituation.Hit:
                //ateþ edildiðinde
                FireBallThrowCounter -= Time.deltaTime;
                if (FireBallThrowCounter <= 0)
                {
                    FireBallThrowCounter = FireBallThrowTime;
                    var NewFireBall=Instantiate(FireBall,FireBallCenter.position,FireBallCenter.rotation);
                    NewFireBall.transform.localScale = -RedBoss.localScale;
                    CurrentSituation = RedBossSituation.Move;
                }
      
                
                break;
            case RedBossSituation.TakeDamage:
                if (TakeDamageCounter > 0)
                {
                    TakeDamageCounter -= Time.deltaTime;

                    if (TakeDamageCounter <= 0)
                    {
                        CurrentSituation = RedBossSituation.Move;
                    }
                }
                break;
            case RedBossSituation.Move:
               
                if (isdirectionright)
                {
                    RedBoss.position += new Vector3(movement_speed * Time.deltaTime, 0f, 0f);
                    if (RedBoss.position.x > righttarget.position.x)
                    {
                        RedBoss.localScale = new Vector3(-4.607166f, 4.607166f, 4.607166f);
                        isdirectionright = false;
                        StopMoveFNC();
                    }
                 
                }
                else
                {
                    RedBoss.position -= new Vector3(movement_speed * Time.deltaTime, 0, 0);
                    if (RedBoss.position.x < lefttarget.position.x)
                    {
                        RedBoss.localScale = new Vector3(4.607166f, 4.607166f, 4.607166f);
                        isdirectionright = true;
                        StopMoveFNC();
                       
                    }


                }

                break;
            default:
                break;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            TakeDamageFNC();
        }
    }
 
    public void TakeDamageFNC()
    {
        CurrentSituation = RedBossSituation.TakeDamage;
        TakeDamageCounter = TakeDamageTime;

        anim.SetTrigger("Hit");
        
    }
    void StopMoveFNC()
    {
        CurrentSituation = RedBossSituation.Hit;
        FireBallThrowCounter = FireBallThrowTime;
        anim.SetTrigger("Stop_Move");
    }
}
