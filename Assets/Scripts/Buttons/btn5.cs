using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn5 : MonoBehaviour
{
    public GameObject stone2;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            stone2.transform.position = new Vector3(stone2.transform.position.x, 16.1153f, stone2.transform.position.z);
        }
    }
}
