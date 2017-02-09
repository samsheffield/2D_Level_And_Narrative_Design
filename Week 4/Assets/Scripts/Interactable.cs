using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class Interactable : MonoBehaviour
{
    // Setting a stop location
    public Transform stopLocation;
    public InteractEvent interactEvent;
    public bool disableOnExit;

    // Always keep outline on?
    public bool keepOutlineOn;
    private Outline outline;
    private bool outlineSet;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    // These 2 methods are used when MoveToClick arrives at or leaves the target
    // Child components of the InteractEvent class are enabled or disbabled
    public void EnableEvent()
    {
        outline.enabled = true;
        interactEvent.enabled = true;
    }

    public void DisableEvent()
    {
        interactEvent.enabled = false;
        outline.enabled = false;
        outlineSet = false;  
    }

    // Set outlines
    private void OnMouseDown()
    {
        outline.color = 1;
        outlineSet = true;
    }
    private void OnMouseEnter()
    {
        if (!outlineSet)
            outline.color = 0;

        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        if (!outlineSet && !keepOutlineOn)
        {
            outline.enabled = false;
        }
    }
}
