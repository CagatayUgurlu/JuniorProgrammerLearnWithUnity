using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft4 : MonoBehaviour
{
    public float speed = 30f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
