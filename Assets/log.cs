using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class log : MonoBehaviour
{
    public bool canMove = true;

    public GameObject logDeath, audio;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            canMove = false;

            logDeath.SetActive(true);

            audio.SetActive(true);

            StartCoroutine(Wait());
        }

    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        FindAnyObjectByType<CharacterController>().isAlive = false;
    }
}
