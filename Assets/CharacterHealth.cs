using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 9; // Número total de sprites de vida
    public int currentHealth;
    public SpriteRenderer characterSprite;
    public Sprite[] healthSprites; // Array de sprites de vida
    public LivesManager livesManager; // Referencia al LivesManager

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthDisplay();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth; // Restablece la salud del personaje
            livesManager.LoseLife(); // Disminuye una vida
        }
        UpdateHealthDisplay();
    }

    void UpdateHealthDisplay()
    {
        characterSprite.sprite = healthSprites[currentHealth];
    }
}
