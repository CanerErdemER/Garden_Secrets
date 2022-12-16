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
    public bool gameover=false;
    player_controller player_Controller;
    private void Awake()
    {
        cc = Object.FindObjectOfType<collectibles_controller>();
        player_Controller = Object.FindObjectOfType<player_controller>();
        instance = this;
    }
    private void Update()
    {
       
    }
    public void FinishSceneFNC()
    {
      
        SceneManager.LoadScene(scenename);
    }

    public void GameOverFNC()
    {
        print("çalýþýyom ben");
    }
   

   
}
