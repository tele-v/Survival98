using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float tiempoActual = 0f;
    float tiempoInicial = 60f;

    [SerializeField] Text contador;

    void Start()
    {
        tiempoActual = tiempoInicial;
    }

    void Update()
    {
        if (tiempoActual > 0)
        {
            tiempoActual -= 1 * Time.deltaTime;

            if (tiempoActual <= 0)
            {
                tiempoActual = 0;
            }
        }

        if (tiempoActual < 60.5 && tiempoActual > 30.5)
        {
            contador.color = Color.green;
        }

        else if (tiempoActual < 30.5 && tiempoActual > 5.5)
        {
            contador.color = Color.yellow;
        }

        else if (tiempoActual < 5.5 && tiempoActual > 0)
        {
            contador.color = Color.red;
        }


        if (tiempoActual == 0)
        {
            SceneManager.LoadScene("Scenes/Perder");
            Cursor.visible = true;
        }

        contador.text = tiempoActual.ToString("0");
    }
}
