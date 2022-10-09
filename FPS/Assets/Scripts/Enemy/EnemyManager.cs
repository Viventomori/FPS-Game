using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [HideInInspector] 
    public GameObject[] enemy;
    public int plusPower;
    public int plusHealth;
    public Transform target;
    [SerializeField] private float health;
    [SerializeField] private int _power;

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }
   
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
            PowerSystem powerSystem = target.transform.GetComponent<PowerSystem>();
            powerSystem.AddPower(plusPower);
            HealthSystem healthSystem = target.transform.GetComponent<HealthSystem>();
            healthSystem.AddHealth(plusHealth);
        }

        void Die()
        {
            gameObject.SetActive(false);
            GameController.instance.EnemyKilled();
        }
    }

    public void AllKill()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject go in enemy)
        {
            go.SetActive(false);
            GameController.instance.EnemyKilled();
        }
    }
}
