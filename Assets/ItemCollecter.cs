using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollecter : MonoBehaviour
{
    public bool stone, stick, rope;
    public GameObject kairaStatu;

    void Update()
    {
        if (stone && stick && rope)
        {
            kairaStatu.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PickUp"))
        {
            if (other.GetComponent<itemChanger>()!= null)
            {
                if(other.GetComponent<itemChanger>().stone == true)
                {
                    stone = true;
                    Destroy(other.gameObject);
                }

                if(other.GetComponent<itemChanger>().stick == true)
                {
                    stick = true;
                    Destroy(other.gameObject);
                }
                
                if(other.GetComponent<itemChanger>().rope == true)
                {
                    rope = true;
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
