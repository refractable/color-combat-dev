using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private float speed = 20;
    public float zRange = 200;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Sets the projectile at a constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
