using UnityEngine;

public class spiderguymove : MonoBehaviour
{

    private Rigidbody2D spider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        spider = GetComponent<Rigidbody2D>();

        spider.linearVelocity = Vector2.down;

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= 0.6f)
        {
            spider.linearVelocity = Vector2.zero;
        }

    }
    
}
