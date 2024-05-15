using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_PlayerDamage : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<VidasPersonaje>().LoseLife(damage);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
