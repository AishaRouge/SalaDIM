using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajes : MonoBehaviour
{
    public void Mensaje1()
    {
        print("El foco se ha encendido");
    }

    public void Mensaje2()
    {
        print("El foco se ha apagado");
    }

    public void Mensaje3(string nombre)
    {
        print("Hola " + nombre + ", ¿Cómo estas?");
    }
}
