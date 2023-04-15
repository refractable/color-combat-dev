using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int level;
    public GameObject enemy;
    public GameObject enemyTwo;
    public GameObject player;

    public int enemyCount;
    public int playerCheck;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        playerCheck = GameObject.FindGameObjectsWithTag("Player").Length;
        if (enemyCount == 0)
        {
            levelUp(level);
        }
    }
    
    void levelUp(int level1)
    {
        level += 1;
        
        if (level == 1)
        {
            Instantiate(enemy, new Vector3(-30f, 1f, 35f), enemy.transform.rotation);
        }
        if (level == 2)
        {
            Instantiate(enemy, new Vector3(-30f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-35f, 1f, 50f), enemy.transform.rotation);
        }
        if (level == 3)
        {
            Instantiate(enemy, new Vector3(45f, 1f, 50f), enemy.transform.rotation);
        }
        if (level == 4)
        {
            Instantiate(enemy, new Vector3(40f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(47f, 1f, 50f), enemy.transform.rotation);
        }
        if (level == 5)
        {
            Instantiate(enemy, new Vector3(-30f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(48f, 1f, 50f), enemy.transform.rotation);
        }
        if (level == 6)
        {
            Instantiate(enemy, new Vector3(-35f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-35f, 1f, 50f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(51f, 1f, 47f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(47f, 1f, 50f), enemy.transform.rotation);
        }
        if (level == 7)
        {
            Instantiate(enemy, new Vector3(-35f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-35f, 1f, 50f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(51f, 1f, 47f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(47f, 1f, 50f), enemy.transform.rotation);
        }
        if (level == 8)
        {
            Instantiate(enemyTwo, new Vector3(7f, 1f, 78f), enemyTwo.transform.rotation);
            Instantiate(enemyTwo, new Vector3(10f, 1f, 80f), enemyTwo.transform.rotation);
        }
        if (level == 9)
        {
            Instantiate(enemy, new Vector3(-30f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-35f, 1f, 50f), enemy.transform.rotation);
        }
        if (level >= 10)
        {
            Instantiate(enemy, new Vector3(-35f, 1f, 35f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-35f, 1f, 50f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(51f, 1f, 47f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(47f, 1f, 50f), enemy.transform.rotation);
        }
    }
}
