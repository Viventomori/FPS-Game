using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Vector3 changePos;
    [SerializeField] private Transform player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            Debug.Log("Work");
            Debug.Log(player.transform.position);
            player.transform.position = Vector3.Scale(player.transform.position, changePos);//dont work
            Debug.Log(player.transform.position);
        }
    }
}
