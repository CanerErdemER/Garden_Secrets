using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public int collectedstarcount;
    collectibles_controller cc;
    private void Awake()
    {
        cc = Object.FindObjectOfType<collectibles_controller>();
    }
   

   
}
