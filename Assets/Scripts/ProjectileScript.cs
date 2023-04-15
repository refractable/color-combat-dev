using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private float speed = 20;
    public float zRange = 200;

    // Start is called before the first frame update
    void Start()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Sets the projectile at a constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" && col.gameObject.tag == "Head")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }

    }
}
