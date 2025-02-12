using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StationarySpawnerStats", menuName = "Enemies/StationarySpawnerStats", order = 1)]
public class StationarySpawnerStats : EnemyBaseStats
{
    [Header("Spawner Related Stats")]
    [Tooltip("How many get spawned each time it tries to spawn (does not exceed spawn limit)")]
    [SerializeField] [Range(1, 5)] int spawnAmount;
    [Tooltip("Determines if the spawn order is random or in order from top to bottom")]
    [SerializeField] bool isRandom;
    [SerializeField] GameObject[] prefabsToSpawn;
    [SerializeField] [Range(0.5f, 10)] float timeToSpawn;
    [SerializeField] [Range(1, 15)] int spawnLimit;


    public bool IsRandom
    {
        get => isRandom;
    }

    public int SpawnLimit
    {
        get => spawnLimit;
    }

    public float TimeToSpawn
    {
        get => timeToSpawn;
    }

    public GameObject[] PrefabsToSpawn
    {
        get => prefabsToSpawn;
    }

    public int SpawnAmount
    {
        get => spawnAmount;
    }
}
