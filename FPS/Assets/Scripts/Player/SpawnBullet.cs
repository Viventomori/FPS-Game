using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject playerAttack;
    [SerializeField] 
    private GameObject player;
    private Vector3 spawn;
    private ObjectPool objectPool;

    void Start()
    {
        objectPool = FindObjectOfType<ObjectPool>();
    }

    public void CreateBullet()
    {
        spawn = player.transform.position;
        GameObject playerBullet = objectPool.GetObject(playerAttack);
        playerBullet.transform.position = spawn;
    }

}
