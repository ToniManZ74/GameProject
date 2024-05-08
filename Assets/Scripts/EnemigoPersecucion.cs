using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPersecucion : MonoBehaviour
{
    Vector2 enemyPos;
    public GameObject PlayerM;
    bool perseguirP;
    public int speed;
    public Transform objetivo;

    void Update()
    {
        float anguloRadianes = Mathf.Atan2(objetivo.position.y - transform.position.y, objetivo.position.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);

        if (perseguirP)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemyPos, speed * Time.deltaTime);
            
        }

        if (Vector2.Distance(transform.position, enemyPos) > 12f)
        {
            perseguirP = false;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            enemyPos = PlayerM.transform.position;
            perseguirP = true;
        }
    }
}
