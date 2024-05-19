using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour
{
    public GameObject text, text2;

    private bool isFound;

    private void Update()
    {
        if (FindAnyObjectByType<Key>() != null)
        isFound = FindAnyObjectByType<Key>().key;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isFound == false)
        {
            text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
