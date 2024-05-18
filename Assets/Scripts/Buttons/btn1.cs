using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn1 : MonoBehaviour
{
    public GameObject stone1;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            stone1.transform.position = new Vector3(stone1.transform.position.x, 17.97f, stone1.transform.position.z);
        }
    }
}
