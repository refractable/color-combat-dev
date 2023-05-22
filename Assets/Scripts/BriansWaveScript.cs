using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriansWaveScript : MonoBehaviour
{
    public int level;
    public GameObject enemy;
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

        if (level >= 1)
        {
            Instantiate(enemy, new Vector3(-14f, 21f, 23f), enemy.transform.rotation);
        }
    }
}
