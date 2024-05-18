using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn8 : MonoBehaviour
{
    public GameObject stone3;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            stone3.transform.position = new Vector3(stone3.transform.position.x, 18.43f, stone3.transform.position.z);
        }
    }
}
