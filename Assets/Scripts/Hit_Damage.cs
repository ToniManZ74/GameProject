using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Damage : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            collision.GetComponent<VidasEnemigo>().vida -= damage;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
