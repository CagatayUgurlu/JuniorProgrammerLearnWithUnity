using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    // Private variables
    [SerializeField] private float speed = 20f;
    [SerializeField] private float horsePower = 0f;
    [SerializeField] private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;

    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
