using UnityEngine;
using UnityEngine.InputSystem;


public class topdowncontroler : MonoBehaviour
{

    InputAction moveAction;
    public Rigidbody2D body;

    public float walkspeed;
    public float framerate;

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

    void FixedUpdate()
    {
       
        
    }
}
