using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestEnemy : MonoBehaviour
{
    private GameObject[] enemy;
    private GameObject closest;
    [SerializeField] private GameObject needEnemy;


    private void Start()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
    }

    GameObject FindClosestEnemy()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in enemy)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    void Update()
    {
        needEnemy = FindClosestEnemy();
    }
}
