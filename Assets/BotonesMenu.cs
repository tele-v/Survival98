using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{
    public void iniciarJuego()
    {
        SceneManager.LoadScene("Scenes/Juego");
    }

    public void salirJuego()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
