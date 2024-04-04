// Script del jugador
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     public NewBehaviourScript NewBehaviourScript;
    public GameObject bulletPrefab;
    public Transform firePoint;
    private Vector2 direction = Vector2.right; // Default direction
    

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        // Update the direction based on input
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            direction = new Vector2(moveHorizontal, moveVertical);
            firePoint.right = direction; // Rotate the firePoint to face the direction of movement
        }

        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
          if (Input.GetKey(KeyCode.LeftArrow))
    {
        GetComponent<SpriteRenderer>().flipX = true;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
        GetComponent<SpriteRenderer>().flipX = false;
    }
    }

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Goal"))
    {
        // Muestra la pantalla de Felicitaciones
        NewBehaviourScript.Setup();
    }
}
    void Shoot()
    {
        // Instantiate the bullet at the fire point
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        // Set the bullet's direction
        bullet.GetComponent<Bullet>().SetDirection(direction);

        
    }
}
