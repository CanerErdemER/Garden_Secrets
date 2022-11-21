using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_controller : MonoBehaviour
{
    [SerializeField]
    Image heart1_img, heart2_img, heart3_img;
    [SerializeField]
    Sprite maxheart, halfheart, emtheart;
    heal_controller heal_Controller;
    private void Awake()
    {
        heal_Controller = Object.FindObjectOfType<heal_controller>();

    }
    public void healtUIhupdateFNC()
    {
        switch (heal_Controller.health)
        {
            case 6:
                heart1_img.sprite= maxheart;
                heart2_img.sprite = maxheart;   
                heart3_img.sprite = maxheart;
                break;
            case 5:
                heart1_img.sprite = maxheart;
                heart2_img.sprite = maxheart;
                heart3_img.sprite = halfheart;
                break;
            case 4:
                heart1_img.sprite = maxheart;
                heart2_img.sprite = maxheart;
                heart3_img.sprite = emtheart;
                break;
            case 3:
                heart1_img.sprite = maxheart;
                heart2_img.sprite = halfheart;
                heart3_img.sprite = emtheart;
                break;
            case 2:
                heart1_img.sprite = maxheart;
                heart2_img.sprite = emtheart;
                heart3_img.sprite = emtheart;
                break;
            case 1:
                heart1_img.sprite = halfheart;
                heart2_img.sprite = emtheart;
                heart3_img.sprite = emtheart;
                break;
            case 0:
                heart1_img.sprite = emtheart;
                heart2_img.sprite = emtheart;
                heart3_img.sprite = emtheart;
                break;



        }
    }
}

