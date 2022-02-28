using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSEnemySpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] enemies;
    [SerializeField] private Transform spawnLocation;

    private float secondsPerSpawn = 3;
    private float lastSpawnTime = 0;
    void Update()
    {
        secondsPerSpawn -= (0.05f * Time.deltaTime);
        if (Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position))
        {
            lastSpawnTime = Time.time;
            Spawn();
        }
    }
    private void Spawn()
    {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}
