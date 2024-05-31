using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject menuPause;

    public void ButtonPause()
    {
        menuPause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ButtonPlay()
    {
        menuPause.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ButtonPause();
        }
    }
}
