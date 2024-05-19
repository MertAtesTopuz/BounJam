using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bear : MonoBehaviour
{
    private Animator anim;

    public GameObject bearr;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Animation()
    {
        anim.SetBool("run", bearr.transform.position != Vector3.zero);
    }
}
