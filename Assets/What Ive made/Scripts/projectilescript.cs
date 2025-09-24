using System.Xml.Serialization;
using UnityEngine;

public class projectilescript : MonoBehaviour
{

    [SerializeField] private float projectilespeed;

    private Rigidbody2D projectilebody;

    private void Awake()
    {

        // need to make it so projectile spawns just above player or make Istrigger work
        projectilebody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * projectilespeed);
    }


}
