using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    public void TakeDamage(float damage)
    {
        slider.value -= damage;
    }

    public void NewHealth(int health)
    {
        PlayerPrefs.SetFloat("health", slider.value);
    }
}
