using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattle : MonoBehaviour
{
    public Slider bossbar;
    public GameObject winScreen;

    void BossTakeDamage(float damage)
    {
        bossbar.value -= damage;
    }

    private void Update()
    {
        if (bossbar.value == 0)
        {
            gameObject.SetActive(false);
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
