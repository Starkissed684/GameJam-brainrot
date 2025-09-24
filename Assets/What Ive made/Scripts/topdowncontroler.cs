using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class topdowncontroler : MonoBehaviour
{

    InputAction moveAction;
    public Rigidbody2D body;

    public float walkspeed;
    Vector2 move;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("move");

        

    }

    // Update is called once per frame
    void Update()
    {

        move = moveAction.ReadValue<Vector2>();
        move *= walkspeed;
        //transform.Translate(new Vector3(move.x, move.y, 0) * Time.deltaTime);

        body.linearVelocity = move;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enimie")
        {
            SceneManager.LoadScene("losescreen");

        }

    }

    void FixedUpdate()
    {
       
        
    }
}
