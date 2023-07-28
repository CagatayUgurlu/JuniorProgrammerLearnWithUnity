using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPrototype4 : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;
    public float speed = 50f;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        //playerRb.AddForce(Vector3.forward * verticalInput * speed * Time.deltaTime);
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);
    }
}
