using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player; 

    [SerializeField] private float timer = 5;
    private float bulletTime;

    public GameObject enemyBullet; 
    public Transform spawnPoint;
    public float enemySpeed; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        ShootAtPlayer();
    }
    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if(bulletTime > 0) return; 

        bulletTime = timer; 

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform);
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f);
    }
}
