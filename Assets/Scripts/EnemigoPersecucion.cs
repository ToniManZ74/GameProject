using UnityEngine;

public class EnemigoPersecucion : MonoBehaviour
{
    Vector2 enemyPos;
    public GameObject player;
    bool perseguir;
    public int speed;
    public Transform objetivo;
    private Animator animacion;

    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    void Update()
    {
        float anguloRadianes = Mathf.Atan2(objetivo.position.y - transform.position.y, objetivo.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);

        if (perseguir) //Si es cierto, el enemigo empezará a atacar y, además, la vista y la direccion de este se dirigirá hacia el jugador
        {
            transform.position = Vector2.MoveTowards(transform.position, enemyPos, speed * Time.deltaTime);
            animacion.SetBool("ataque", perseguir);
        }

        if (Vector2.Distance(transform.position, enemyPos) > 12f) //Si es falso, el enemigo no perseguirá al jugador
        {
            perseguir = false;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player")) //Si el jugador está dentro del rango del enemigo, comienza la persecución 
        {
            enemyPos = player.transform.position;
            perseguir = true;
        }
    }
}
