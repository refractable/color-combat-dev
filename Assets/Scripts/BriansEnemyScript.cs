using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriansEnemyScript : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent enemy;
    public Transform target;
    public float minDistanceSqr;
    // Start is called before the first frame update
    private void Awake()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();    
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            var destPosition = target.position;
            var sqrDistance = (transform.position - destPosition).sqrMagnitude;

            enemy.destination = destPosition;
            enemy.isStopped = (sqrDistance <= minDistanceSqr);
        }
        else
        {
            enemy.isStopped = true;
        }
    }
}