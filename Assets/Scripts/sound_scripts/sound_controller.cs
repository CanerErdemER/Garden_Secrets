using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_controller : MonoBehaviour
{
    public static sound_controller instance;
    public AudioSource[] sound_effects;

    private void Awake()
    {
        instance= this;
    }
    public void playvoiceeffects(int voice)
    {
        sound_effects[voice].Play();
    }
}
