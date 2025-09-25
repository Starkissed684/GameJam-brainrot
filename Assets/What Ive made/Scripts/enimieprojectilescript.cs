using UnityEngine;

public class enimieprojectilescript : MonoBehaviour
{
   
    public eninieshots eninimeshotmove;

    public float cooldown;     

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (cooldown <= 0 && transform.position.y <= 0.4f)
        {
            var postion = transform.position + transform.forward;
            var rotation = transform.rotation;
            var projectile = Instantiate(eninimeshotmove, postion, rotation);
            cooldown = 2f;
        }

        cooldown -= Time.deltaTime;
    }
}
