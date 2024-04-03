using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento del personaje

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Obtiene la entrada del usuario

        Vector3 movement = new Vector3(moveHorizontal, 0, 0); // Crea un vector de movimiento

        transform.position += movement * speed * Time.deltaTime; // Mueve el personaje
    }
}