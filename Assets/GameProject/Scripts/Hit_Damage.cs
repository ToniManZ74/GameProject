using UnityEngine;

public class Hit_Damage : MonoBehaviour
{
    public int damage;
    public new string tag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (tag == "Enemy")
        {
            if (collision.CompareTag("Enemy")) //Si alcanza al enemigo, se coge el valor de vida que tiene el enemigo y se le resta la cantidad de da�o correspondiente
            {
                collision.gameObject.GetComponentInParent<VidasEnemigo>().vida -= damage;
            }
        }
        
        if (tag == "Jugador")
        {
            if (collision.CompareTag("Jugador")) //Si el enemigo alcanza al jugador, se llamar� a la funcion LoseLife que tiene el jugador para que pierda la cantidad de da�o deseada
            {
                collision.gameObject.GetComponentInParent<VidasPersonaje>().LoseLife(damage);
            }
        }
    }
}
