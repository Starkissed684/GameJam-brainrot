using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    public void playbutton()
    {

        SceneManager.LoadScene("Game");

    }

    public void endbutton()
    {

        Application.Quit();

    }
    

}
