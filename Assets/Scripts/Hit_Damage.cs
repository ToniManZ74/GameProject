using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Damage : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo")) //Si alcanza al enemigo, se coge el valor de vida que tiene el enemigo y se le resta la cantidad de daño correspondiente
        {
            collision.GetComponent<VidasEnemigo>().vida -= damage;
        }
    }

}
