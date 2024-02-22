using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    bool isPlayerClick = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isPlayerClick)
        {
            clickedOn();
        }
    }

    void clickedOn()
    {
        spriteRenderer.color = Color.green;
    }

    private void OnMouseDown()
    {
        isPlayerClick = true;
    }
}
