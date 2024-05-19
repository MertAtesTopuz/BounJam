using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baltaControl : MonoBehaviour
{
    public Door door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Rope")
        {
            door.isCut = true;
            Destroy(other.gameObject);
        }
    }
}
