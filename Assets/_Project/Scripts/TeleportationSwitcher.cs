using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class TeleportationSwitcher : MonoBehaviour
{
    [SerializeField] private InputActionReference teleportActionToggler;
    private XRRayInteractor teleportInteractor;

    private void Awake()
    {
        teleportInteractor = GetComponent<XRRayInteractor>();
        teleportInteractor.enabled = false;
    }

    private void OnEnable()
    {
        teleportActionToggler.action.performed += ToggleRayInteractor;
    }

    private void OnDisable()
    {
        teleportActionToggler.action.performed -= ToggleRayInteractor;
    }

    private void ToggleRayInteractor(InputAction.CallbackContext obj)
    {
        //Si está activado, lo desactiva, y viceversa
        teleportInteractor.enabled = !teleportInteractor.enabled;
    }

}
