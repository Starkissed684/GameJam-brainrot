using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class darkgreenmove : MonoBehaviour
{

    private Rigidbody2D darkgreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        darkgreen = GetComponent<Rigidbody2D>();

        darkgreen.linearVelocity = new UnityEngine.Vector2 (1, -1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "mepw")
        {
            darkgreen.linearVelocity = new UnityEngine.Vector2 (-1, -1);
            Debug.Log("touched right wall");
        }

        if (collision.gameObject.tag == "wall")
        {
            darkgreen.linearVelocity = new UnityEngine.Vector2 (1, -1);
            Debug.Log("touched left wall");
        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
