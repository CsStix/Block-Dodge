using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnpoints;

    public GameObject blockPrefab;

    public float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    

    private void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

        
    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnpoints.Length);

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnpoints[i].position, Quaternion.identity);
            }
        }
    }
}
