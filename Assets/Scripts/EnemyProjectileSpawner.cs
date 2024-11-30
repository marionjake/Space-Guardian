using UnityEngine;

public class EnemyProjectileSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject enemyProjectilePrefab;
    public float spawnTimer;
    public float spawnMax = 10;
    public float spawnMin = 5;
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Instantiate(enemyProjectilePrefab, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);;
        }
    }
}
