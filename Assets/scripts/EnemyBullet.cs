using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int damage = 1;
    public float speed = 20f;
    public Rigidbody2D rb;
    public float lifetime = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        CharacterHealth characterHealth = other.GetComponent<CharacterHealth>();

        if (characterHealth != null) // Si el objeto tiene un script CharacterHealth
        {
            // Hace daño al personaje
            characterHealth.TakeDamage(damage);
            // Destruye la bala     
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}