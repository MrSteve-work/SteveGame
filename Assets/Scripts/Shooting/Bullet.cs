using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Bullet : MonoBehaviour
{
    private GameObject Player;
    public float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player");
        if (Player != null)
        {
            if (Player.transform.localScale.x > 0)
            {
                rb.linearVelocity = transform.right * speed;
            }
            else
            {
                rb.linearVelocity = -transform.right * speed;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Destroy(gameObject, 2f);
    }
}