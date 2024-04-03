using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab; // El prefab de la bala
    public Transform bulletSpawnPoint; // El punto donde se creará la bala
    public int bulletCount = 10; // El número de balas disponibles

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && bulletCount > 0) // Si se presiona el botón de disparo y quedan balas
        {
            Shoot();
            bulletCount--;
        }
    }

    void Shoot()
    {
        // Crea una nueva instancia de la bala en la posición del punto de disparo
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        // Aquí puedes añadir código para hacer que la bala se mueva
    }
}
