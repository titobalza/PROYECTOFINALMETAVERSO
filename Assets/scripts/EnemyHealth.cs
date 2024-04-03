using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 5; // La salud máxima del enemigo
    public int currentHealth; // La salud actual del enemigo
    public SpriteRenderer enemySprite; // El sprite del enemigo
    public Sprite[] healthSprites; // Los sprites de la barra de vida del enemigo
    public Sprite[] deathSprites; // Los sprites de la animación de muerte del enemigo

    void Start()
    {
        currentHealth = maxHealth; // Inicializa la salud del enemigo
        UpdateHealthDisplay(); // Actualiza la barra de vida del enemigo
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Reduce la salud del enemigo
        if (currentHealth <= 0)
        {
            // Inicia la corutina de la animación de muerte
            StartCoroutine(PlayDeathAnimation());
        }
        else
        {
            UpdateHealthDisplay(); // Actualiza la barra de vida del enemigo
        }
    }

    IEnumerator PlayDeathAnimation()
    {
        // Reproduce cada sprite de la animación de muerte
        foreach (Sprite deathSprite in deathSprites)
        {
            enemySprite.sprite = deathSprite;
            yield return new WaitForSeconds(0.1f); // Espera un corto período de tiempo entre cada sprite
        }
        // Destruye el enemigo después de que se haya reproducido la animación de muerte
        Destroy(gameObject);
    }

    void UpdateHealthDisplay()
    {
        enemySprite.sprite = healthSprites[currentHealth]; // Cambia el sprite de la barra de vida del enemigo
    }
}
