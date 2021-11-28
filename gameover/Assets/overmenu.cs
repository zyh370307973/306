using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class overmenu : MonoBehaviour
{
    public void b2menu ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);


    }
    public void quit()
    {
        Application.Quit();
    }
    public void load() 
    {
        
    }
}
