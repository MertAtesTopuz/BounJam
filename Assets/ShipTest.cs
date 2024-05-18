using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipTest : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(speed * Time.deltaTime, rb.velocity.y, rb.velocity.z);
    }
}
