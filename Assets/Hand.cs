using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public GameObject item;
    public bool canPick;
    public GameObject itemHolder;

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.CompareTag("PickUp") )
            {
                if(canPick == false && item == null)
                {
                    other.GetComponent<Rigidbody>().isKinematic = true;
                    item = other.gameObject;
                    other.transform.SetParent(transform);
                    other.transform.position = transform.position;
                    canPick = true;
                }
                else
                {
                    item.transform.SetParent(itemHolder.transform);
                    item.GetComponent<Rigidbody>().isKinematic = false;
                    canPick = false;
                    item = null;
                }
            }
        }
        
    }

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.CompareTag("PickUp") )
            {
                if(canPick == false && item == null)
                {
                    item = other.gameObject;
                    other.GetComponent<Rigidbody>().isKinematic = true;
                    other.transform.SetParent(transform);
                    other.transform.position = transform.position;
                    canPick = true;
                }
                else
                {
                    item.transform.SetParent(itemHolder.transform);
                    item.GetComponent<Rigidbody>().isKinematic = false;
                    canPick = false;
                    item = null;
                }
            }
        }
    }
}