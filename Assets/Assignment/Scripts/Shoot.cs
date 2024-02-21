using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform shootPoint;

    public GameObject bulletPrefab;
    public GameObject sword;

    public Animator swordSwing;
    Animator animator;

    public float bulletForce = 20f;

    private void Start()
    {
        swordSwing = sword.GetComponent<Animator>();
        animator = GetComponent<Animator>();
    }

    void ShootBullet()
    {

        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootPoint.up * bulletForce, ForceMode2D.Impulse);  
    }

    void SwingSword()
    {
        sword.SetActive(true);
        swordSwing.Play("SwordSwing");

        Invoke(nameof(disableSword), 2f);

    }

    void disableSword()
    {
        sword.SetActive(false);
    }


}
