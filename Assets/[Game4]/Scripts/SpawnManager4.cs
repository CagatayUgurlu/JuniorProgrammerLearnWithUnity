using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager4 : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    private PlayerController4 playerController4Script;
    private int randomObstacle;
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
        playerController4Script = GameObject.Find("Player").GetComponent<PlayerController4>();
    }

    void Update()
    {
        
    }
    void SpawnObstacles()
    {
        if (playerController4Script.gameOver == false)
        {
            randomObstacle = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[randomObstacle], spawnPosition, obstaclePrefabs[randomObstacle].transform.rotation);
        }

    }
}
