using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{

    public Transform target;
    public float speed = 4.0f;
    Rigidbody rig;
    public GameObject enemyprojectile;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        Physics.IgnoreCollision(enemy.GetComponent<Collider>(), GetComponent<Collider>());
        InvokeRepeating("SpawnProjectile", 1.0f, 2.0f);
    }

    void SpawnProjectile()
    {
        Instantiate(enemyprojectile, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // Make enemy follow player
        Vector3 pos=Vector3.MoveTowards(transform.position, target.position,speed*Time.fixedDeltaTime);
        transform.LookAt(target);
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);
        }
    }
}
