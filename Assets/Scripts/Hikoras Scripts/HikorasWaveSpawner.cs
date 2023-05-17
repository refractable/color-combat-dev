using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HikorasWaveSpawner : MonoBehaviour
{
    // Each Enemy Game Object
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    // The count of the level, enemies left, and enemies that need to be spawned
    private int level;
    private int enemyCount1;
    private int enemyCount2;
    private int enemyCount3;
    private int enemySpawn1;
    private int enemySpawn2;
    private int enemySpawn3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount1 = GameObject.FindGameObjectsWithTag("Enemy1").Length;
        enemyCount2 = GameObject.FindGameObjectsWithTag("Enemy2").Length;
        enemyCount3 = GameObject.FindGameObjectsWithTag("Enemy3").Length;
        if (enemyCount1 == 0 && enemyCount2 == 0 && enemyCount3 == 0)
        {
            levelUp(level);
        }
    }
    void levelUp(int level1)
    {
        // counts level up
        level += 1;
        // starts level one and spawns 5 enemies
        if (level == 1)
        {
            while (enemySpawn1 != 5)
            {
                Instantiate(enemy1, new Vector3(8.85f, 1.7f, -12.50f), enemy1.transform.rotation);
                enemySpawn1 ++;
            }
            while (enemySpawn2 != 3)
            {
                Instantiate(enemy2, new Vector3(56.26f, 7f, -5.27f), enemy2.transform.rotation);
                enemySpawn2 ++;
            }
        }
        if (level == 2)
        {
            while (enemySpawn1 != 8)
            {
                Instantiate(enemy1, new Vector3(8.85f, 1.7f, -12.50f), enemy1.transform.rotation);
                enemySpawn1 ++;
            }
            while (enemySpawn2 != 8)
            {
                Instantiate(enemy2, new Vector3(56.26f, 7f, -5.27f), enemy2.transform.rotation);
                enemySpawn2 ++;
            }
        }
        if (level == 3)
        {
            while (enemySpawn1 != 25)
            {
                Instantiate(enemy1, new Vector3(8.85f, 1.7f, -12.50f), enemy1.transform.rotation);
                enemySpawn1 ++;
            }
            while (enemySpawn2 != 25)
            {
                Instantiate(enemy2, new Vector3(56.26f, 7f, -5.27f), enemy2.transform.rotation);
                enemySpawn2 ++;
            }
        }
    }
}