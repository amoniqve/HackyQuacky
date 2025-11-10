using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 3f;   // spawn every 3 seconds
    public float minX = -8f, maxX = 8f; // horizontal spawn range (adjust to camera)
    public float spawnY = 4f;          // vertical position to spawn at

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        float x = Random.Range(minX, maxX);
        Vector3 pos = new Vector3(x, spawnY, 0f);
        Instantiate(coinPrefab, pos, Quaternion.identity);
    }
}
