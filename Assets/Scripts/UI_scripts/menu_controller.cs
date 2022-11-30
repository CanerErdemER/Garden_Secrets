using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour
{
    public string scanename;
    public void Startgame()
    {
        SceneManager.LoadScene(scanename);
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
