using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesFinales : MonoBehaviour
{
    public void volverMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void Start()
    {
        Cursor.visible = true;
    }
   
}
