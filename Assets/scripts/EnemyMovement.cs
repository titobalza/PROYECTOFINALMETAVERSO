using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public float speed = 2f; // Velocidad de movimiento del enemigo
   
    public float distance1 = 5f; // Distancia que el enemigo recorrerá de izquierda a derecha
    public float distance2 = 3f;
    private bool movingRight = true; // Determina si el enemigo se está moviendo hacia la derecha
   
    
    public GameObject bulletPrefab; // El prefab de la bala
    public Transform balaSpawnPoint; // El punto donde se creará la bala
    public float fireRate = 1f; // La tasa a la que el enemigo dispara
    private float nextFireTime = 0f; // El tiempo hasta el próximo disparo

    // Referencia al Rigidbody2D del enemigo
    private Rigidbody2D rb;

    void Start()
    {
        // Obtener el componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Actualizamos el movimiento en cada frame
    void Update()
    {
        // Movemos al enemigo en la dirección correcta
        if (movingRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        // Si el enemigo alcanza uno de los extremos, cambiamos su dirección
        if (transform.position.x >= distance1 && movingRight)
        {
            movingRight = false;
        }
        else if (transform.position.x <= distance2 && !movingRight)
        {
            movingRight = true;
        }

       

        // Si es el momento de disparar, dispara
        if (Time.time > nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1/fireRate;
        }
    }

    // Verificar si el enemigo está en el suelo
    


 
    void Shoot()
    {

        // Crea una nueva instancia de la bala en la posición del punto de disparo
        GameObject bullet = Instantiate(bulletPrefab, balaSpawnPoint.position, balaSpawnPoint.rotation);
        
    }
}

