using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandController : MonoBehaviour
{


    //Estado
    public InputActionReference JoyStick_North_Reference;

    //Right Controller Grab
    public XRRayInteractor xrRayInteractor_grab;
    public ActionBasedController actionBasedController_grab;
    public LineRenderer lineRenderer_grab;
    public XRInteractorLineVisual xrInteractorLineVisual_grab;

    //Right Controller Teleport
    public XRRayInteractor xrRayInteractor_teleport;
    public ActionBasedController actionBasedController_teleport;
    public LineRenderer lineRenderer_teleport;
    public XRInteractorLineVisual xrInteractorLineVisual_teleport;


    //Métodos propios
    private void JoystickArribaPresionado(InputAction.CallbackContext context)
    {

        xrRayInteractor_grab.enabled = false;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        xrRayInteractor_teleport.enabled = true;
        xrInteractorLineVisual_teleport.enabled = true;
    }

    private void JoystickArribaLiberado(InputAction.CallbackContext context)
    {
        Invoke("JoystickArribaLiberadoInvoke", 0.005f);
    }

    private void JoystickArribaLiberadoInvoke()
    {
        xrRayInteractor_grab.enabled = true;
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        xrRayInteractor_teleport.enabled = false;
        xrInteractorLineVisual_teleport.enabled = false;
    }


    //Metodos heredados
    private void OnEnable()
    {
        JoyStick_North_Reference.action.performed += JoystickArribaPresionado;
        JoyStick_North_Reference.action.canceled += JoystickArribaLiberado;
    }



    private void OnDisable()
    {
        JoyStick_North_Reference.action.performed -= JoystickArribaPresionado;
        JoyStick_North_Reference.action.canceled -= JoystickArribaLiberado;
    }
}