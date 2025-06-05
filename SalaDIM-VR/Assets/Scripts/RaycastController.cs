using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRRaycastController : MonoBehaviour
{
    public int rango = 10;
    public Transform rayOrigin; // Asignar en el inspector (ej. RightHand Controller)
    public InputActionProperty vrActionButton; // Asignar en el inspector (ej. botón A)

    private void Update()
    {
        if (rayOrigin == null) return;

        RaycastHit hit;
        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit, rango))
        {
            if (vrActionButton.action.WasPressedThisFrame())
            {
                LightController luz = hit.collider.GetComponent<LightController>();
                if (luz != null)
                {
                    luz.OnOffLuz();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        if (rayOrigin != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(rayOrigin.position, rayOrigin.forward * rango);
        }
    }
}
