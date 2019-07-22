using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Wave Configuration")]

public class WaveConfig : ScriptableObject {

    // Configuration Paramters
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject pathPrefab;
    [SerializeField] float timeBetweenSpawns = 0.5f;
    [SerializeField] float spawnRandomFactor = 0.3f;
    [SerializeField] int numberOfEnemies = 5;
    [SerializeField] float moveSpeed = 2f;

    // Return the enemy that the wave will consist of
    public GameObject GetEnemyPrefab() { return enemyPrefab; }

    // Returns the waypoints for the enemy wave
    public List<Transform> GetWaypoints() {
        var waveWaypoints = new List<Transform>();
        foreach (Transform child in pathPrefab.transform) {
            waveWaypoints.Add(child);
        }
        return waveWaypoints;
    }

    // Get functions for the purpose of the Enemy Spawner
    public float GetTimeBetweenSpawns() { return timeBetweenSpawns; }
    public float GetSpawnRandomFactor() { return spawnRandomFactor; }
    public int GetNumberOfEnemies() { return numberOfEnemies; }
    public float GetMoveSpeed() { return moveSpeed; }

}
