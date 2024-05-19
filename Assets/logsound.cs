using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logsound : MonoBehaviour
{
    public GameObject logaud;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            logaud.SetActive(true);
        }
    }
}
