using UnityEngine;



public class winbuttonscriipt : MonoBehaviour
{
    private Rigidbody2D winbutton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winbutton = GetComponent<Rigidbody2D>();

        winbutton.linearVelocity = Vector2.down * 2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
