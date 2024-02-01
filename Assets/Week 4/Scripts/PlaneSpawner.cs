using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{
    
    public GameObject plane;
    public float spawnRate = 2;
    float spawnTimer = 0;
    float minValue = -5;
    float maxValue = 5;
    float minSpeed = 1;
    float maxSpeed = 3;
    void Start()
    {
    }

    void Update()
    { 

        if (spawnTimer < spawnRate)
        {
            spawnTimer = spawnTimer + Time.deltaTime;   
        }
        else
        {
            Instantiate(plane, new Vector3(Random.Range(minValue, maxValue), Random.Range(minValue, maxValue), 0), transform.rotation);
            spawnTimer = 0;
        }
    }
}
