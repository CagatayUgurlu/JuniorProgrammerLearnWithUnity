using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager3 : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 12.0f; //Z location enemy spawn
    private float xSpawnRange = 10.0f;
    private float zPowerupRange = 3.0f;
    private float ySpawn = 0.75f;

    private float powerUpSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;


    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy",startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerUpSpawnTime);
        //SpawnRandomEnemy();
        //SpawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 SpawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerup, SpawnPos, powerup.gameObject.transform.rotation);
    }
}