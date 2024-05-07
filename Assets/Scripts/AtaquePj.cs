using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePj : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private Animator animacion;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    void Update()
    {
        animacion.SetBool("Atacar", Input.GetKeyDown(KeyCode.T));
        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    Debug.Log("T key was pressed.");
        //}
    }

    
}
