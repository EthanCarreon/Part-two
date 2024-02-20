using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattle : MonoBehaviour
{
    public Slider bossbar;

    void BossTakeDamage(float damage)
    {
        bossbar.value -= damage;
        Debug.Log(bossbar.value);
    }

    private void Update()
    {
        if (bossbar.value == 0)
        {
            gameObject.SetActive(false);
        }
    }

}
