using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractions : MonoBehaviour
{
    public void LogHoverEnter(HoverEnterEventArgs args)
    {
        Debug.Log($"{gameObject.name} Hover Enter by: {args.interactableObject}");
    }
    public void LogHoverExit(HoverExitEventArgs args)
    {
        Debug.Log($"{gameObject.name} Hover Exit by: {args.interactableObject}");
    }
    public void LogSelectEnter(SelectEnterEventArgs args)
    {
        Debug.Log($"{gameObject.name} Select Enter by: {args.interactableObject}");
    }
    public void LogSelectExit(SelectExitEventArgs args)
    {
        Debug.Log($"{gameObject.name} Select Exit by: {args.interactableObject}");
    }
    public void LogActivate(ActivateEventArgs args)
    {
        Debug.Log($"{gameObject.name} Activate by: {args.interactableObject}");
    }
    public void LogDeactivate(DeactivateEventArgs args)
    {
        Debug.Log($"{gameObject.name} Deactivate by: {args.interactableObject}");
    }
}
