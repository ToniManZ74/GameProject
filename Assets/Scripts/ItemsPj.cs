using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPj : MonoBehaviour
{
    public enum EstadoItem { SinItem, Invencibilidad, Velocidad };
    public EstadoItem estadoActual = EstadoItem.SinItem;
    public float duracionV = 3f;
    public float duracionI = 3f;
    public float powerUpTime = 0f;
    public bool isInvincible = false;
    private AudioSource audio;
    public AudioClip sound;
    public AudioClip sound2;



    void Start()
    {
        audio = GetComponent<AudioSource>();
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
            powerUpTime += Time.deltaTime;
            if (powerUpTime <= duracionI)
            {
                audio.PlayOneShot(sound);
                Time.timeScale = 0.5f;
            }
            else
            {
                Time.timeScale = 1f;
                NoItemOn();
            }
        }
        else if (colision.gameObject.CompareTag("pocion"))
        {
            powerUpTime += Time.deltaTime;
            if (powerUpTime <= duracionI)
            {
                audio.PlayOneShot(sound2);
                isInvincible = true;
                Debug.Log("Invencible");
            }
            else
            {
                isInvincible = false;
                NoItemOn();
                Debug.Log("Fin de la invencibilidad");
            }
        }
    }
}
