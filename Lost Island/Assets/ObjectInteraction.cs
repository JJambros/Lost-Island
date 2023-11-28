using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class ObjectInteraction : MonoBehaviour
{
    public string instructionText = "Press A to row to shore";
    public GameObject popupPrefab;

    private XRGrabInteractable grabInteractable;
    private GameObject popupUI;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to events
        grabInteractable.onHoverEntered.AddListener(OnHoverEnter);
        grabInteractable.onHoverExited.AddListener(OnHoverExit);
    }

    private void OnHoverEnter(XRBaseInteractor interactor)
    {
        // Create the popup UI
        if (popupPrefab != null && popupUI == null)
        {
            popupUI = Instantiate(popupPrefab, transform.position, Quaternion.identity, transform);
            TextMeshProUGUI textMesh = popupUI.GetComponentInChildren<TextMeshProUGUI>();
            if (textMesh != null)
            {
                textMesh.text = instructionText;
            }
        }
    }

    private void OnHoverExit(XRBaseInteractor interactor)
    {
        // Destroy the popup UI
        if (popupUI != null)
        {
            Destroy(popupUI);
            popupUI = null;
        }
    }
}
