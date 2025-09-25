using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerprojectilescript : MonoBehaviour
{    
    public projectilescript projectilmove;

    public float cooldown;     

    public void Start()
    {
        //projectilemove = InputSystem.actions.FindAction("shoot");
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            var postion = transform.position + transform.forward;
            var rotation = transform.rotation;
            var projectile = Instantiate(projectilmove, postion, rotation);
            cooldown = 0.5f;
        }

        cooldown -= Time.deltaTime;


    }
}
