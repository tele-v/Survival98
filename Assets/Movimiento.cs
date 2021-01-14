using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public CharacterController controller;


    public float speed = 12f;
    public float gravedad = -9.8f;

    Vector3 velocidad;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocidad.y += gravedad * Time.deltaTime;

        controller.Move(velocidad * Time.deltaTime);
    }
}
