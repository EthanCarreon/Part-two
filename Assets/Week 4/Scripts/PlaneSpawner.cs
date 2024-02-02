using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{

    public GameObject plane;
    
    float randomSpeed;
    float randomRotation;

    float spawnTimer = 0;
    public float spawnRate = 2;

    float minValue = -5;
    float maxValue = 5;

    public Sprite[] planesArray;
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
            var newPlane = Instantiate(plane, new Vector3(Random.Range(minValue, maxValue), Random.Range(minValue, maxValue), 0), transform.rotation);

            randomSpeed = Random.Range(1f, 3f);
            newPlane.GetComponent<Plane>().speed = randomSpeed;

            randomRotation = Random.Range(0f, 360f);
            newPlane.GetComponent<Rigidbody2D>().rotation = randomRotation;

            Sprite randomSprite = planesArray[Random.Range(0, planesArray.Length)];
            newPlane.GetComponent<SpriteRenderer>().sprite = randomSprite;

            spawnTimer = 0;
        }
    }
}