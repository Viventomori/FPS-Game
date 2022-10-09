using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlueBullet : MonoBehaviour
{
    public GameObject blueAttack;
    [SerializeField] 
    private GameObject blueTarget;
    private Vector3 spawn;
    private ObjectPool objectPool;


    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
        StartCoroutine(CreateBlueAttack());
    }

    private IEnumerator CreateBlueAttack()
    {
        while(true)
        {
            spawn = blueTarget.transform.position; 
            GameObject blueBullet = objectPool.GetObject(blueAttack);
            blueBullet.transform.position = spawn;
            yield return new WaitForSeconds(3);
        }
    }
}
