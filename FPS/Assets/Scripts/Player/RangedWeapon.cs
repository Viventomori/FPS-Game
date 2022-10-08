using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public int damage = 100;
    public float range = 1000f;
    public Camera fpsCam;

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyManager target = hit.transform.GetComponent<EnemyManager>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
