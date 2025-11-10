using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    private float speed = 2.5f;        
    private float horizontalSpeed = 3f; 
    private float amplitude = 2f;       
    private float startX;               
    private float timeOffset;           

    void Start()
    {
        startX = transform.position.x;
        timeOffset = Random.Range(0f, 2f * Mathf.PI); 
    }

    void Update()
    {
        
        float x = startX + Mathf.Sin(Time.time * horizontalSpeed + timeOffset) * amplitude;
        float y = transform.position.y - speed * Time.deltaTime;
        transform.position = new Vector3(x, y, 0);

        
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
