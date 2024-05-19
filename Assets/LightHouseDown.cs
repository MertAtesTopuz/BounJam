using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouseDown : MonoBehaviour
{
    public Transform targetTeleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && CooldownManager.instance.CanTeleport())
        {
            other.transform.position = targetTeleport.position;
            CooldownManager.instance.StartCooldown();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && CooldownManager.instance.CanTeleport())
        {
            other.transform.position = targetTeleport.position;
            CooldownManager.instance.StartCooldown();
        }
    }
}
