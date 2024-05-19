using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBParkour : MonoBehaviour
{
    [SerializeField]
    public float radius = 5.0f;
    [SerializeField]
    public float speed = 2.0f;

    private Vector3 centerPosition;
    private float angle = 0.0f;

    void Start()
    {

        centerPosition = transform.position;
    }

    void Update()
    {

        angle += speed * Time.deltaTime;


        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        // Küpü yeni pozisyona taşı
        transform.position = new Vector3(x, 0, 0) + centerPosition;
    }
}

