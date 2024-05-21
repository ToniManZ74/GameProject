using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasEnemigo : MonoBehaviour
{
    public int vida;

    void Start()
    {
       
    }

    void Update()
    {
        if (vida <= 0)
        {
            Destroy(gameObject); 
        }
    }
}
