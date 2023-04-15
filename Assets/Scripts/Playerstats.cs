using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerstats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public HealthBar healthBar;
    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }
    private void Update()
    {
        if (currentHealth == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "EnemyProjectile")
        {
            TakeDamage(25f);
            Debug.Log("Hit");
        }
        if (col.gameObject.tag == "Enemy")
        {
            TakeDamage(10f);
            Debug.Log("Hit");
        }
    }
}
