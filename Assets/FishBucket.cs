using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBucket : MonoBehaviour
{
    public EnemyMovement enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<FishCheck>() != null)
        {
            enemy.isFish=true;
        }
    }
}
