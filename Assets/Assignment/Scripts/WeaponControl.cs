using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public GameObject gun;
    public GameObject swordimage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun.SetActive(false);
            swordimage.SetActive(true);
        }

       if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun.SetActive(true);
            swordimage.SetActive(false);
        }

       if (gun.activeSelf)
        {
            if (Input.GetMouseButtonDown(1))
            {
                SendMessage("ShootBullet");
            }
        }
       if (swordimage.activeSelf)
        {
            if (Input.GetMouseButtonDown(1))
            {
                SendMessage("SwingSword");
            }
        }
    }
}
