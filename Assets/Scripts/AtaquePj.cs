using UnityEngine;

public class AtaquePj : MonoBehaviour
{
    private Animator animacion;

    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    void Update()
    {
        animacion.SetBool("Atacar", Input.GetKeyDown(KeyCode.Space)); //Pulsa espacio para atacar 
    }
}
