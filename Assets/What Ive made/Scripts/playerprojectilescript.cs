using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerprojectilescript : MonoBehaviour
{

    InputAction projectilemove; 

    
    public projectilescript projectilmove;

    

    public void Start()
    {
        //projectilemove = InputSystem.actions.FindAction("shoot");
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var postion = transform.position + transform.forward;
            var rotation = transform.rotation;
            var projectile = Instantiate(projectilmove, postion, rotation);

        }



    }
}
