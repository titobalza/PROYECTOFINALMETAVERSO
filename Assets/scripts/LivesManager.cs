using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public NewBehaviourScript NewBehaviourScript;
    public SpriteRenderer livesRenderer; // El SpriteRenderer que muestra las vidas
    public Sprite[] livesSprites; // Array de sprites de vida
    private int currentLives;

    void Start()
    {
        currentLives = livesSprites.Length - 1; // Comienza con todas las vidas
        UpdateLivesDisplay();
    }

    public void LoseLife()
    {
        if (currentLives > 0)
        {
            currentLives--; // Pierde una vida
            UpdateLivesDisplay();
        }
        else
        {
           NewBehaviourScript.Setup();

        }
    }

    void UpdateLivesDisplay()
    {
        livesRenderer.sprite = livesSprites[currentLives]; // Actualiza el sprite de vidas
    }
}

