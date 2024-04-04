using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float duration = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Encuentra el script Bullet del jugador
            Bullet bullet = other.GetComponentInChildren<Bullet>();
           
            
                // Duplica el daño
                bullet.DoubleDamage();

                // Espera 10 segundos y luego restablece el daño
                StartCoroutine(ResetBulletDamage(bullet));
                Debug.Log(bullet.damage);
                Debug.Log("hola");
            

            // Desactiva el power up
             Destroy(gameObject);
        }
    }

    IEnumerator ResetBulletDamage(Bullet bullet)
    {
        yield return new WaitForSeconds(duration);
        bullet.ResetDamage();
    }
}
