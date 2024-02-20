using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 5f;
    Vector3 target;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = transform.position;
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        Vector2 displacement = (Vector2)target - rb.position;
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg - 90f;   

        if (displacement.magnitude > 0.01f)
        {
            rb.rotation = angle;
            rb.MovePosition(rb.position + (Vector2)target * speed * Time.deltaTime);
        }
        else
        {
            rb.position = transform.position;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            SendMessage("BossTakeDamage", -1);
        }
    }


}
