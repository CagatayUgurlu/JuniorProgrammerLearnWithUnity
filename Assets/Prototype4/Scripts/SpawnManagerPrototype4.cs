using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerPrototype4 : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9f;
    void Start()
    {
        //Vector3 randomPos = GenerateSpawnPosition();

        Instantiate(enemyPrefab, GenerateSpawnPosition() , enemyPrefab.transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
