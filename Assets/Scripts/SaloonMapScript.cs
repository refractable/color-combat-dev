using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaloonMapScript : MonoBehaviour
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

        if (level == 1)
        {
            Instantiate(enemy, new Vector3(-82.26f, 0.49f, 3.63f), enemy.transform.rotation);
        }
        if (level == 2)
        {
            Instantiate(enemy, new Vector3(66.6f, 0.49f, 7.87f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(66.6f, 0.49f, 12.14f), enemy.transform.rotation);
        }
        if (level == 3)
        {
            Instantiate(enemy, new Vector3(-1.2f, 2.83f, -59.69f), enemy.transform.rotation);
        }
        if (level == 4)
        {
            Instantiate(enemy, new Vector3(66.6f, 0.49f, 7.87f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-82.26f, 0.49f, 3.63f), enemy.transform.rotation);
        }
        if (level >= 5)
        {
            Instantiate(enemy, new Vector3(-1.2f, 2.83f, -59.69f), enemy.transform.rotation);
            Instantiate(enemy, new Vector3(-82.26f, 0.49f, 3.63f), enemy.transform.rotation);
        }
        if (level >= 6)
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}

