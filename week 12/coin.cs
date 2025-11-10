using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
             ScoreManager.instance?.AddScore(1); // 
            Destroy(gameObject);
        }
    }
}
