using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown3 : MonoBehaviour
{
    public float speed = 5.0f;

    private float zBoundaryDestroy = -10f;
    private Rigidbody objectRb;

    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);
        if(transform.position.z < zBoundaryDestroy)
        {
            Destroy(gameObject);
        }
    }
}
