using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage_controller : MonoBehaviour
{
    heal_controller PhC;
    private void Awake()
    {
        PhC = Object.FindObjectOfType<heal_controller>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PhC.TakeDamage();
        }
    }
}
