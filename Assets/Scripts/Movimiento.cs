using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimiento : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float velocidad;
    public Vector2 direccion;
    public SpriteRenderer sprite;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
       
        rb2D.MovePosition(rb2D.position + direccion * velocidad * Time.fixedDeltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(horizontal * velocidad, 0);

        if (horizontal > 0)
        {
            sprite.flipY = false;
        }

        if (horizontal < 0)
        {
            sprite.flipY = true;
        }

    }

}
