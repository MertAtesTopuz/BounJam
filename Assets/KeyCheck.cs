using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour
{
    public GameObject text, text2, panel;

    private bool isFound, canEscape;

    private void Update()
    {
        Debug.Log(isFound);

        if (FindAnyObjectByType<Key>() != null)
        isFound = FindAnyObjectByType<Key>().key;
        
        canEscape = isFound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(canEscape == false)
        {
            text.SetActive(true);
        }

        if(canEscape == true)
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
