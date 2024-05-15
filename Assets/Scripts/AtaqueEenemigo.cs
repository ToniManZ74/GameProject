using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEenemigo : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    private Animator animacion;


    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
