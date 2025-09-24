using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class titlebutton : MonoBehaviour
{

    public Rigidbody2D Tbutton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void titlescreen()
    {
        SceneManager.LoadScene("title");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
