using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable interactable;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletPos;

    private void OnEnable()
    {
        interactable.activated.AddListener(Fire);
    }

    private void Fire(ActivateEventArgs args)
    {
        var instance = GameObject.Instantiate(bullet);
        instance.transform.position = bulletPos.position;
        instance.transform.rotation = bulletPos.rotation;
    }

}
