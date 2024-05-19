using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform targetObj;
    //public PlayerAwaerness playerAwaerness;
    public TargetArea area;
    public float stopDistance;
    public bool isFish;
    public GameObject fishBucket;

    void Start()
    {
        //playerAwaerness = GetComponent<PlayerAwaerness>();
        targetObj = GameObject.FindGameObjectWithTag("Player").transform;
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
            transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 6 * Time.deltaTime);
            
        }
        transform.LookAt(targetObj);
    }
}
