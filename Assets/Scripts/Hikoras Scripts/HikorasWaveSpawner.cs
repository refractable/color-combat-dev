using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HikorasWaveSpawner : MonoBehaviour
{
    // Each Enemy Game Object
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    // The count of the level, enemies left, and enemies that need to be spawned
    private int level;
    private int enemyCount1;
    private int enemyCount2;
    private int enemyCount3;
    private int enemyCount4;
    private int enemySpawn1;
    private int enemySpawn2;
    private int enemySpawn3;
    private int enemySpawn4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Counts the number of enemys, if all enemies are defeated then start next level.
        enemyCount1 = GameObject.FindGameObjectsWithTag("Enemy1").Length;
        enemyCount2 = GameObject.FindGameObjectsWithTag("Enemy2").Length;
        enemyCount3 = GameObject.FindGameObjectsWithTag("Enemy3").Length;
        enemyCount4 = GameObject.FindGameObjectsWithTag("Enemy4").Length;
        if (enemyCount1 == 0 && enemyCount2 == 0 && enemyCount3 == 0 && enemyCount4 == 0)
        {
            levelUp(level);
        }
    }
    void levelUp(int level1)
    {
        // counts level up
        level += 1;
        // starts level 1
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
            while (enemySpawn1 != 10)
            {
                Instantiate(enemy1, new Vector3(8.85f, 1.7f, -12.50f), enemy1.transform.rotation);
                enemySpawn1 ++;
            }
            while (enemySpawn2 != 6)
            {
                Instantiate(enemy2, new Vector3(56.26f, 7f, -5.27f), enemy2.transform.rotation);
                enemySpawn2 ++;
            }
        }
        if (level == 3)
        {
            while (enemySpawn1 != 18)
            {
                Instantiate(enemy1, new Vector3(8.85f, 1.7f, -12.50f), enemy1.transform.rotation);
                enemySpawn1 ++;
            }
            while (enemySpawn2 != 10)
            {
                Instantiate(enemy2, new Vector3(56.26f, 7f, -5.27f), enemy2.transform.rotation);
                enemySpawn2 ++;
            }
            while (enemySpawn3 != 4)
            {
                Instantiate(enemy3, new Vector3(57f, 15f, 22f), enemy3.transform.rotation);
                enemySpawn3++;
            }
        }
        if (level == 4)
        {
            while (enemySpawn1 != 20)
            {
                Instantiate(enemy1, new Vector3(8.85f, 1.7f, -12.50f), enemy1.transform.rotation);
                enemySpawn1++;
            }
            while (enemySpawn3 != 15)
            {
                Instantiate(enemy3, new Vector3(57f, 15f, 22f), enemy3.transform.rotation);
                enemySpawn3++;
            }
            while (enemySpawn4 != 4)
            {
                Instantiate(enemy4, new Vector3(25f, 15f, -49f), enemy4.transform.rotation);
                enemySpawn4++;
            }
        }
        if (level == 5)
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}