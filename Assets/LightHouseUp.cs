using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouseUp : MonoBehaviour
{
    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(254, 69.5f, 92.5f);
            player.transform.Rotate(0, -96.3f, 0);
        }
    }
}
