using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class plank1 : MonoBehaviour
{
    public GameObject plank, player;

    public LayerMask plankLayer;

    public Transform groundCheck;
    public float groundDistance = 0.4f;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //  player = other.gameObject;
            // other.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.SetParent(plank.transform);
            //m.position = transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);    
        }
    }
}
