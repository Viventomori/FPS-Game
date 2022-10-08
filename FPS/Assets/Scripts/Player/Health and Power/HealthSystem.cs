using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class HealthSystem : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int healthMax;

    public IHealthBar healthBar;

    private void Awake()
    {
        healthBar.SetMaxHealth(healthMax);
    }
    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.SetHealth(health);
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
  
}
