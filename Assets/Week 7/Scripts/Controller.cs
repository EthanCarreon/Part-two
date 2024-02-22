using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Controller : MonoBehaviour
{

    public Slider chargeSlider;
    float chargeValue;
    public float maxCharge = 100;
    
    Vector2 direction;

    public static Ball score;
    public static PlayerController SelectedPlayer { get; private set; }

    public static void increaseScore(Ball score)
    {
        score.currentScore++;
        Debug.Log("current score: " + score.currentScore);
    }
    public static void SetSelectedPlayer(PlayerController player)
    {
        if (SelectedPlayer != null)
        {
            SelectedPlayer.clickedOn(false);
        }

        SelectedPlayer = player;
        SelectedPlayer.clickedOn(true);
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            SelectedPlayer.Move(direction);
            direction = Vector2.zero;
            chargeValue = 0;
            chargeSlider.value = chargeValue;
        }
    }

    private void Update()
    {
        if (SelectedPlayer == null) return;

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            chargeValue = 0;
            direction = Vector2.zero;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            chargeValue += Time.deltaTime;
            chargeValue = Mathf.Clamp(chargeValue, 0, maxCharge);
            chargeSlider.value = chargeValue;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            direction = ((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)SelectedPlayer.transform.position).normalized * chargeValue;
        }
    }
}
