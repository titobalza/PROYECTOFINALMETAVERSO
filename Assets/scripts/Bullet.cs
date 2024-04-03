using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1; // El daño que hace la bala
    public float speed = 20f;
    public Rigidbody2D rb;
    public float lifetime = 2.0f; // El tiempo en segundos que la bala existirá

    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        CharacterHealth characterHealth = other.GetComponent<CharacterHealth>();
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();

        if (characterHealth != null) // Si el objeto tiene un script CharacterHealth
        {
            // Hace daño al personaje
            characterHealth.TakeDamage(damage);
            // Destruye la bala
            Destroy(gameObject);
        }
        else if (enemyHealth != null) // Si el objeto tiene un script EnemyHealth
        {
            // Hace daño al enemigo
            enemyHealth.TakeDamage(damage);
            // Destruye la bala
            Destroy(gameObject);
        }
    }
}
