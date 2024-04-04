using UnityEngine;
using UnityEngine.SceneManagement; // Necesitas este namespace para reiniciar la escena

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject gameOverScreen; // Referencia a tu pantalla de Game Over

    public void Setup()
    {
        gameOverScreen.SetActive(true); // Activa la pantalla de Game Over
    }

    public void RestartGame()
    {
        // Reinicia la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
