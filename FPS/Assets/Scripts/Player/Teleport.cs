using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Vector3 changePos;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Work");
            player.transform.position =  Vector3.Scale(player.transform.position, changePos);//dont work
        }
    }
}
