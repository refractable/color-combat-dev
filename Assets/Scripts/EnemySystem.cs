using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{

    private Transform target;
    public float speed = 50f;
    Rigidbody rig;
    public GameObject enemyprojectile;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Head").transform;
        rig = GetComponent<Rigidbody>();
        InvokeRepeating("SpawnProjectile", Random.Range(4.0f, 10.0f), Random.Range(2.0f, 10.0f));
        Physics.IgnoreCollision(enemyprojectile.GetComponent<Collider>(), GetComponent<Collider>());
    }

    void SpawnProjectile()
    {
        Instantiate(enemyprojectile, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        // Make enemy follow player
        Vector3 pos=Vector3.MoveTowards(transform.position, target.position, speed*Time.fixedDeltaTime);
        transform.LookAt(target);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Projectile")
        {
        }
    }
}
