using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTPROJECTILE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColllisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
