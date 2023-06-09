using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject enemyPrefab, enemies;


    public float enemyBurstCount = 3, spawnTime = 1;

    Transform location;
    float updateTime;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            updateTime = Time.time + spawnTime;
            spawnPoints.Add(child);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > updateTime)
            SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        if (enemies.transform.childCount < enemyBurstCount)
        {
            location = spawnPoints[Random.Range(0, transform.childCount)];
            var enemyInstance = Instantiate(enemyPrefab, location);
            enemyInstance.transform.SetParent(enemies.transform);
            enemyInstance.transform.LookAt(Vector3.zero);
        }
    }
}
