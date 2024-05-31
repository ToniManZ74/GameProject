using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class sceneController : MonoBehaviour
{


    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuInicial");
    }


    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

}
