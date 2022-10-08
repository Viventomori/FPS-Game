using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //[SerializeField] private GameObject prefabs;
    private float placeX;
    private float placeZ;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private float timeDelay;
    [SerializeField] private float minTimeDelay;

    private void Start()
    {
        timeToSpawn = 0f;
    }

    public void Update()
    {
        timeToSpawn = timeToSpawn + 1f * Time.deltaTime;

        if(timeToSpawn >= timeDelay)
        {
            if (timeDelay != minTimeDelay)
            {
                timeToSpawn = 0f;
                CreateEmemy();
                timeDelay--;
            }
            else if(timeDelay == minTimeDelay)
            {
                timeToSpawn = 0f;
                CreateEmemy();
            }
        }
       
    }

    public void CreateEmemy()
    {
        Vector3 center = transform.position;
        Vector3 pos = RandomCircle(center, 5.0f);
        Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
        //Instantiate(prefabs, pos, rot);
        ObjectPooler.Instance.SpawnFromPool("RedTarget", pos, rot);
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        placeX = Random.Range(-15f, 15f);
        placeZ = Random.Range(-15f, 15f);
        Vector3 pos;
        pos.x = center.x + placeX;
        pos.y = center.y;
        pos.z = center.z+ placeZ;
        return pos;
    }
}
