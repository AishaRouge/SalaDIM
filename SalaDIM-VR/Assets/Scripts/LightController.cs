using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject luzObjeto;
    public bool luz;
    private bool luzOnOff;

    public void OnOffLuz()
    {

        luzOnOff = !luzOnOff;

        if (luzOnOff == true)
        {
            luzObjeto.SetActive(true);
            print("El foco se ha encendido");
        }
        else
        {
            luzObjeto.SetActive(false);
            print("El foco se ha apagado");
        }
    }
}
