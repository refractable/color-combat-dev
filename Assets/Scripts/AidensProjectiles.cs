using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidensProjectiles : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision col)
    {
    }
    public void DestroyOnHit(Collision col)
    {
        Destroy(gameObject);
    }

}
