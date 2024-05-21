using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_PlayerDamage : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) //Si alcanza al jugador, se llamar� a la funcion LoseLife que tiene el jugador para que pierda la cantidad de da�o deseada
        {
            collision.gameObject.GetComponentInParent<VidasPersonaje>().LoseLife(damage); 
        }
    }
}
