using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
    public void quitgame()
    {
        Application.Quit();

    }
    public void UIenable()
    {
        GameObject.Find("Canvas/mainmenu/UI").SetActive(true);

    }
   
}
