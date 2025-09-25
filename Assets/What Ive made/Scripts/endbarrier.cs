using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endbarrier : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "enimie")
        {
            SceneManager.LoadScene("losescreen");
            Debug.Log("enimie ht");
        }

        if (collision.gameObject.tag == "win")
        {
            SceneManager.LoadScene("winscreen");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
