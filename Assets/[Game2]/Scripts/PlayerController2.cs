using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 10f;

    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate is allows you to copy prefab
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

}
