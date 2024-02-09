using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float speed = 3;
    float destroyTimer = 10;
    float spawnTimer = 5;
    public Transform prefab;
    public Transform spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else if (spawnTimer < 0)
        {
            spawnTimer = 5;
            Instantiate(prefab, spawn.position, spawn.rotation);
        }

        if (destroyTimer > 0)
        {
            destroyTimer -= Time.deltaTime;
        }
        else if (destroyTimer < 0)
        {
            destroyTimer = 10;
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SendMessage("TakeDamage", 1, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
