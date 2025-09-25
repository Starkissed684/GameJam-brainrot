using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class projectilescript : MonoBehaviour
{
    [SerializeField] private float projectilespeed;

    private Rigidbody2D projectilebody;

    private void Awake()
    {

        // need to make it so projectile spawns just above player or make Istrigger work
        projectilebody = GetComponent<Rigidbody2D>();

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enimie")
        {
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Debug.Log("hit enimie");
        }

    }

    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * projectilespeed);
    }


}
