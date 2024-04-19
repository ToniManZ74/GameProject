using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Transform;
    public Vector2 Hrange = Vector2.zero;
    public Vector2 Vrange = Vector2.zero;


    private void LateUpdate()
    {
        Transform.position = new Vector3(Mathf.Clamp(transform.position.x, Vrange.x, Vrange.y), Mathf.Clamp(transform.position.y, Hrange.x, Hrange.y), Transform.position.z);
    }


    void Start()
    {
        Transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
