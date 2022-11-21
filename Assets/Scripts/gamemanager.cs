using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public float star_score = 0;

    public Text star_score_text;

    private void Start()
    {
        star_score_text.text = "Star Points: 0 "+star_score.ToString();
        
    }

    public void updatestar(float star_Score)
    {
        star_score += star_Score;

        star_score_text.text = "Star Points: " + star_score.ToString();
        

        
    }
}
