using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    void Update()
    {
        // if an object goes past the players view in the game, remove that object.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
