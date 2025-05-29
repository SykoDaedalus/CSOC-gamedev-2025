using System.Security.Cryptography;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float initialSpawnTimer;
    private float spawnTimer, altSpawnTimer;
    [SerializeField] private GameObject enemy;

    private void Start()
    {
        spawnTimer = initialSpawnTimer;
        altSpawnTimer = initialSpawnTimer + 1.0f;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        altSpawnTimer -= Time.deltaTime;
        if(spawnTimer < 0) Spawn();
        if(altSpawnTimer < 0) AltSpawn();

        // using two different spawn functions to spawn to the left and right of walls
        // this is temporary to avoid spawning on walls, will use better methods later
    }

    private void Spawn()
    {
        spawnTimer = initialSpawnTimer;
        Vector3 spawnPos = new Vector3(Random.Range(-10.0f, 1.0f), Random.Range(-4.0f, 4.0f), 0.0f);
        Object.Instantiate(enemy, spawnPos, Quaternion.identity);
    }

    private void AltSpawn()
    {
        altSpawnTimer = initialSpawnTimer + 1.0f;
        Vector3 spawnPos = new Vector3(Random.Range(8.5f, 10.5f), Random.Range(-4.0f, 4.0f), 0.0f);
        Object.Instantiate(enemy, spawnPos, Quaternion.identity);
    }
}
