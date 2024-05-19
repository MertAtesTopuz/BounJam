using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform targetObj;
    //public PlayerAwaerness playerAwaerness;
    public TargetArea area;
    public float stopDistance;
    public bool isFish;
    public GameObject fishBucket;

    public bool canMove = true;

    public GameObject bearDeath;

    private AudioSource audio;

    private float speed = 6;

    void Start()
    {
        //playerAwaerness = GetComponent<PlayerAwaerness>();
        targetObj = GameObject.FindGameObjectWithTag("Player").transform;

        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(isFish == true)
        {
            targetObj = fishBucket.transform;
        }
        //float distance = transform.position.z - targetObj.transform.position.z;
        if(area.canTraget == true )
        {
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, speed * Time.deltaTime);
            
        }
        transform.LookAt(targetObj);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canMove = false;

            speed = 0;

            bearDeath.SetActive(true);

            audio.enabled = true;

            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        FindAnyObjectByType<CharacterController>().isAlive = false;
    }
}
