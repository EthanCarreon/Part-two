using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBarTrigger : MonoBehaviour
{
    public GameObject bossbar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bossbar.SetActive(true);
    }
}
