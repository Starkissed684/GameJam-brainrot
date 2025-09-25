using UnityEngine;
using UnityEngine.SceneManagement;


public class eninieshots : MonoBehaviour
{

    [SerializeField] private float projectilespeed;

    public Transform playerpostion;

    private Rigidbody2D enimiebody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {

        enimiebody = GetComponent<Rigidbody2D>();

        var shorthand = (playerpostion.position - transform.position).normalized * projectilespeed;

        enimiebody.linearVelocity = new Vector2(shorthand.x, shorthand.y);


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {

            SceneManager.LoadScene("losescreen");
            Destroy(this.gameObject);

        }

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
