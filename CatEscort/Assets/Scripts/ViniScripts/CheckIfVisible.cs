using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckIfVisible : MonoBehaviour
{
    [Header("Visibility")]
    [Tooltip("This tells you if the GameObject is currently in view of thje camera")]
    public bool isVisible;

    [Header("Event Systems")]
    [Tooltip("Hook this up to the gameobject interactions that are supposed to be done")]
    public UnityEvent Interaction;

    private void OnBecameVisible()
    {
        Debug.Log("can see it");
        isVisible = true;
    }

    private void OnBecameInvisible()
    {
        Debug.Log("False");
        isVisible = false;
    }

    public void InteractEvent()
    {
        if(isVisible == true)
        {
            Interaction.Invoke();
        }
    }
}
