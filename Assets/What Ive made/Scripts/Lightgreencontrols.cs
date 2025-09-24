using UnityEngine;

public class Enimie1controls : MonoBehaviour
{

    private Rigidbody2D lightgreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightgreen =  GetComponent<Rigidbody2D>();

        lightgreen.linearVelocity = Vector2.down;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
