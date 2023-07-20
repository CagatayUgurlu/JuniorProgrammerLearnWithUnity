using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager4 : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    void Update()
    {
        
    }
    void SpawnObstacles()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
