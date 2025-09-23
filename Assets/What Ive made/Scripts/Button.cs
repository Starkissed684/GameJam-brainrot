using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{

    AudioSource buttonaudio;
    public void playbutton()
    {

        GetComponent<AudioSource>().Play();

        SceneManager.LoadScene("Game");

    }

    public void endbutton()
    {

        Application.Quit();

    }


}
