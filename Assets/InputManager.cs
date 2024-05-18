using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private Camera mainCam;
    public GameObject toRemove;
    public List<GameObject> objects = new List<GameObject>();
    public LayerMask checkLayer;
    private LineRenderer line;
    public GameObject ships;

    private void Awake()
    {
        mainCam = Camera.main;
        line = GetComponent<LineRenderer>();
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            return;
        }

        RaycastHit hit ;
        Ray rayHit = mainCam.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(rayHit, out hit, 1000f ,checkLayer))
        {
            print(hit.transform.gameObject);
            objects.Add(hit.transform.gameObject);
        }

        if (objects.Count >= 3)
        {
            objects.RemoveAt(0);
        }
    }

    public void OnClick2(InputAction.CallbackContext context)
    {
        if (!context.started)
        {
            return;
        }

        if(objects.Count >= 2)
        {
            line.enabled = false;

            if(objects[0].CompareTag("Ship"))
            {
                objects[0].transform.SetParent(ships.transform); 
            }
            else
            {
                objects[1].transform.SetParent(ships.transform);
            }

            objects.Clear();
        }
    }

    void Update()
    {
        if(objects.Count >= 2)
        {
            line.enabled = true;
            if(objects[0] != null && objects[1] != null)
            {
                line.SetPosition(0, objects[0].transform.position);
                line.SetPosition(1, objects[1].transform.position);

                if(objects[0].CompareTag("Ship"))
                {
                    objects[0].transform.SetParent(objects[1].transform);
                    objects[0].transform.rotation = objects[1].transform.rotation;
                }
                else
                {
                    objects[1].transform.SetParent(objects[0].transform);
                    objects[1].transform.rotation = objects[0].transform.rotation;
                }
            }
        }
    }
}
