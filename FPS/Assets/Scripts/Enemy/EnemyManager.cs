using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public float health;
    [SerializeField] private int _power;
    public int plusPower;
    public Transform target;
    [HideInInspector]public GameObject[] enemy; 
    
    public void Start()
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
        }

        void Die()
        {
            gameObject.SetActive(false);
        }
    }

    public void AllKill()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject go in enemy)
        {
            go.SetActive(false);
        }
    }
}
