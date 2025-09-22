using System.Xml.Serialization;
using UnityEngine;

public class projectilescript : MonoBehaviour
{

    private Rigidbody2D projectilebody;

    private void Awake()
    {

        projectilebody = GetComponent<Rigidbody2D>();

    }

    public void fire(float speed, Vector3 direction)
    {

        projectilebody.linearVelocity = direction * speed; 

    }


}
