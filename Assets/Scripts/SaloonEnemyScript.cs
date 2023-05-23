using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaloonEnemyScript : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target = GameObject.FindWithTag("Head").transform) ;
        {
            enemy.SetDestination(target.position);
        }
    }

}