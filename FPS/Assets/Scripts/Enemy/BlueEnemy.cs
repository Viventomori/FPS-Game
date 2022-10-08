using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : MonoBehaviour
{
    public GameObject blueAttack;
    public GameObject blueTarget;
    private Vector3 spawn;

    void Start()
    {
        StartCoroutine(CreateBlueAttack());
    }

    private IEnumerator CreateBlueAttack()
    {
        while(true)
        {
            spawn = blueTarget.transform.position; 
            GameObject blueBullet = Instantiate(blueAttack, spawn, Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
}
