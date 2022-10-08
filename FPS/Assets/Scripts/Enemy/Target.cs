using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour, IPooledObject
{
    [SerializeField] public float health;
    [SerializeField] private int _power;
    public int plusPower;
    public Transform target;

    public ObjectPooler pooler;
    

    public void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        pooler = target.transform.GetComponent<ObjectPooler>();
    }
    public void OnObjectSpawn()
    {
        //target = GameObject.FindWithTag("Player").transform;
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
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }

    public void AllKill()
    {
        pooler.pools.ForEach(x => x.prefab.SetActive(false));
        //PowerSystem powerSystem = target.transform.GetComponent<PowerSystem>();
        //powerSystem.UseUlty(plusPower);
    }
}
