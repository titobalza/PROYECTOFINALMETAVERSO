using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damage = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        CharacterHealth characterHealth = other.GetComponent<CharacterHealth>();
        if (characterHealth != null)
        {
            characterHealth.TakeDamage(damage);
        }
    }
}

