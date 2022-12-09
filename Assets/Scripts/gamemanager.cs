using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    public int collectedstarcount;
    collectibles_controller cc;
    public string scenename;
    private void Awake()
    {
        cc = Object.FindObjectOfType<collectibles_controller>();
        instance = this;
    }
    public void FinishScene()
    {
      
        SceneManager.LoadScene(scenename);
    }
   

   
}
