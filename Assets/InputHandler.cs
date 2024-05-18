using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera mainCam;
    private void Awake()
    {
        mainCam = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            return;
        }

        RaycastHit hit ;
        Ray rayHit = mainCam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(rayHit, out hit))
        {
            print(hit.transform.gameObject);
        }
    }
}
