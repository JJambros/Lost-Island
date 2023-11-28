using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using CommonUsages = UnityEngine.XR.CommonUsages;

public class RowToShore : MonoBehaviour
{
    public XRController controller;
    public float rayLength = 10f;

    private void Start()
    {
        // Attempt to find an XRController component on this GameObject
        controller = GetComponent<XRController>();

        // If the XRController component is not directly on this GameObject,
        // you might want to look for it in children or elsewhere in your hierarchy.
        if (controller == null)
        {
            controller = GetComponentInChildren<XRController>();
        }

        // If still not found, you might want to add additional logic
        // to search for XR controllers dynamically in your scene.
        if (controller == null)
        {
            Debug.LogError("XRController not found. Please assign it in the Inspector or ensure it's present in the hierarchy.");
        }
    }

    private void Update()
    {
        if (controller != null)
        {
            if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool isButtonPressed) && isButtonPressed)
            {
                Debug.Log("Button press works");
                TryDestroyObject();
            } 
        } else
        {
            Debug.Log("Controller not assigned");
        }
    }

    private void TryDestroyObject()
    {
        RaycastHit hit;
        if (Physics.Raycast(controller.transform.position, controller.transform.forward, out hit, rayLength))
        {
            DestroyTooltip objectInteraction = hit.collider.GetComponent<DestroyTooltip>();
            if (objectInteraction != null)
            {
                objectInteraction.DestroyObject();
            }
        }

        MoveToBeach moveToBeachScript = FindObjectOfType<MoveToBeach>();
        if (moveToBeachScript != null)
        {
            moveToBeachScript.toBeach();
        }
    }
}
