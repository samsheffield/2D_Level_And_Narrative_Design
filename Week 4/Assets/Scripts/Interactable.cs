using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class Interactable : MonoBehaviour
{
    public Transform stopLocation;
    public InteractEvent interactEvent;
    public bool disableOnExit;
    private Outline outline;
    private bool outlineSet;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

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

    private void OnMouseDown()
    {
        outline.color = 1;
        outlineSet = true;
    }
    private void OnMouseEnter()
    {
        if(!outlineSet)
            outline.color = 0;

        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        if (!outlineSet)
        {
            outline.enabled = false;
        }
    }
}
