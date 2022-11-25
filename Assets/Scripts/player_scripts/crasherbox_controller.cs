using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crasherbox_controller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mushow"))
        {
           Destroy(collision.gameObject);

        }
    }
}
