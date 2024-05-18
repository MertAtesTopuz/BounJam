using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollecter : MonoBehaviour
{
    public bool kaira, otuzbir;
    public GameObject kairaStatu;

    void Update()
    {
        if (kaira && otuzbir)
        {
            kairaStatu.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PickUp"))
        {
            if(other.GetComponent<itemChanger>().kaira == true)
            {
                kaira = true;
                Destroy(other.gameObject);
            }

            if(other.GetComponent<itemChanger>().otuzbir == true)
            {
                otuzbir = true;
                Destroy(other.gameObject);
            }
            
        }
    }
}
