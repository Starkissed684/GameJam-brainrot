using UnityEngine;

public class darkgreenmove : MonoBehaviour
{

    private Rigidbody2D darkgreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        darkgreen = GetComponent<Rigidbody2D>();

        darkgreen.linearVelocity = new Vector2(1, -1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            darkgreen.linearVelocity = darkgreen.linearVelocity * new Vector2(-1, 1);
            Debug.Log("touched wall");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
