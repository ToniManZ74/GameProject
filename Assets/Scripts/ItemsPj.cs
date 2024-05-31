using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPj : MonoBehaviour
{
    public enum EstadoItem { SinItem, Invencibilidad, Velocidad};
    public EstadoItem estadoActual = EstadoItem.SinItem;
    public float duracionV = 3f;
    public float duracionI = 3f;
    public float powerUpTime = 0f;
    public bool isInvincible = false; 




    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) //Pulsa O para hacerte invencible 
        {
            InvencibleOn();
        }
        else if (Input.GetKeyDown(KeyCode.P)) //Pulsa P para ralentizar la velocidad de juego
        {
            VelocidadOn();
        }

        switch (estadoActual)
        {
            case EstadoItem.SinItem:
            break;

            case EstadoItem.Invencibilidad:
                powerUpTime += Time.deltaTime;
                if (powerUpTime <= duracionI)
                {
                    isInvincible = true;
                    Debug.Log("Invencible");
                }
                else
                {
                    isInvincible = false;
                    NoItemOn();
                    Debug.Log("Fin de la invencibilidad");
                }
            break;

            case EstadoItem.Velocidad:
                powerUpTime += Time.deltaTime;
                if (powerUpTime <= duracionI)
                {
                    Time.timeScale = 0.5f;
                }
                else
                {
                    Time.timeScale = 1f;
                    NoItemOn();
                }
            break;
        }
    }

    void InvencibleOn()
    {
        estadoActual = EstadoItem.Invencibilidad;
    }

    void VelocidadOn()
    {
        estadoActual = EstadoItem.Velocidad;
    }

    void NoItemOn()
    {
        estadoActual = EstadoItem.SinItem;
        powerUpTime = 0f;
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("reloj"))
        {
            VelocidadOn();
        }
        else if (colision.gameObject.CompareTag("pocion"))
        {
            InvencibleOn();
        }
    }
}
