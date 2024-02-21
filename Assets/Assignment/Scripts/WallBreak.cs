using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WallBreak : MonoBehaviour
{
    public float wallhealth = 5f;

    public Transform targetPos;
    public AnimationCurve wallbreaking;
    float wallDisplay = 0f;
    Renderer renderer;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (wallhealth == 0)
        {
            wallDestroyed();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SendMessage("WallDamage", 1);
    }

    void WallDamage(float damage)
    {
        wallhealth -= damage;        
    }

    void wallDestroyed()
    {

        wallDisplay += 0.5f * Time.deltaTime;

        float interpolation = wallbreaking.Evaluate(wallDisplay);
        if (transform.localScale.z < 0.1f)
        {
            Destroy(gameObject);
        }
        transform.position = Vector3.Lerp(transform.position, targetPos.position, interpolation);



    }

}
