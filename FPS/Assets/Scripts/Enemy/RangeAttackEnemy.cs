using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttackEnemy : MonoBehaviour
{
    public Transform target;
    public int damageHealth;
    public int damagePower;
    [SerializeField] private float moveSpeed;
    private float attackRadius = 2;
    private Rigidbody myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        MoveTarget();
        AttackCo();
    }

    private void MoveTarget()
    {
        Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        myRigidbody.MovePosition(temp);
    }

    private void AttackCo()
    {
        if(Vector3.Distance(target.position, transform.position) < attackRadius)
        {
            HealthSystem healthSystem = target.transform.GetComponent<HealthSystem>();          
            healthSystem.TakeDamage(damageHealth);
            PowerSystem powerSystem = target.transform.GetComponent<PowerSystem>();
            powerSystem.MinusPower(damagePower);
            gameObject.SetActive(false);
        }
    }
}
