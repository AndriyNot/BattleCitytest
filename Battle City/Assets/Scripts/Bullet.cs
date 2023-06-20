using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _bulletRigidbody;
    private float _bulletSpeed = 5;

    private void Start()
    {
        _bulletRigidbody = GetComponent<Rigidbody2D>();
        _bulletRigidbody.velocity = transform.up * _bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("blok"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("blok"))
        {
            Destroy(gameObject);
        }
    }
}
