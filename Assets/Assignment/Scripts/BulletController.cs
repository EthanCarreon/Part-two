using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    public GameObject[] Enemies;
    public GameObject boss;
    public GameObject wall;

    bool allEnemiesDead = false;

    private void Update()
    {
        if (!allEnemiesDead)
        {
            allEnemiesDead = deadEnemyCheck();

            if (allEnemiesDead)
            {
                wall.SetActive(false);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        foreach (GameObject enemy in Enemies)
        {
                if (collision.gameObject == enemy)
                {
                    enemy.SetActive(false);
                    BulletDestroy();
                }
                else
                {
                    BulletDestroy();
                }
            
        }

        if (collision.gameObject == boss)
        {
            SendMessage("BossTakeDamage", 1);
        }
    }

    bool deadEnemyCheck()
    {
        foreach (GameObject enemy in Enemies)
        {
            if (enemy.activeSelf)
            {
                return false;
            }
        }

        return true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BulletDestroy();
    }

    public void BulletDestroy()
    {
        Destroy(gameObject);
    }

}
