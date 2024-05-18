using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool doorOpen;
    private Animator anim;
    public Animator logAnim;
    public bool isCut;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isFall", doorOpen);

        if(doorOpen == true && isCut == false)
        {
            logAnim.SetTrigger("isAttack");
            isCut = true;
        }
    }
}
