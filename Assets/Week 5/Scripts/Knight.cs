using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Knight : MonoBehaviour
{
    Vector2 destination;
    Vector2 movement;

    public float speed = 3;
    Rigidbody2D rb;
    Animator animator;
    bool clickingOnSelf = false;
    public float health;
    public float maxHealth = 5;
    bool isDead = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = maxHealth;

        //health = PlayerPrefs.GetFloat("health", 0);
    }


    void FixedUpdate()
    {
        if (isDead) return;

        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {   
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !clickingOnSelf && !EventSystem.current.IsPointerOverGameObject())
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButtonDown(1) && !clickingOnSelf)
        {
            animator.SetTrigger("Attack");
        }

        animator.SetFloat("Movement", movement.magnitude);
        
    }

    private void OnMouseDown()
    {
        if (isDead) return;

        clickingOnSelf = true;
        SendMessage("TakeDamage", 1);

    }

    private void OnMouseUp()
    {
        clickingOnSelf = false;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);

        PlayerPrefs.SetFloat("health", health);

        Debug.Log("Health: " + health);

        if (health == 0)
        {
            isDead = true;
            animator.SetTrigger("Death");
        }
        else
        {
            isDead = false;
            animator.SetTrigger("TakeDamage");
        }
    }
}
