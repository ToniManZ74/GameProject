using UnityEngine;

public class Fondo : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadFondo;
    private Vector2 vectorFondo;
    private Material materialFondo;

    private void Awake()
    {
        materialFondo = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        vectorFondo = velocidadFondo * Time.deltaTime;
        materialFondo.mainTextureOffset += vectorFondo;
    }
}