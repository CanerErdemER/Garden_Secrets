using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballscripts : MonoBehaviour
{
    Rigidbody2D Rb;

    public float speed;

    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Rb.velocity =new Vector2( speed * Time.deltaTime,transform.position.y);
    }
}
