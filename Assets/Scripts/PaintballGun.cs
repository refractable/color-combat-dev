using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintballGun : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnProjectile()
	{
        Instantiate(projectile, transform.position, projectile.transform.rotation);
	}
}
