using UnityEngine;

public class VidasEnemigo : MonoBehaviour
{
    public int vida;

    void Update()
    {
        if (vida <= 0)
        {
            Destroy(gameObject); 
        }
    }

}
