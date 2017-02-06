using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Don't forget!
using cakeslice;

public class HandleOutline : MonoBehaviour
{

    private Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    private void OnMouseEnter()
    {
        outline.color = 0;
        outline.enabled = true;
    }

    private void OnMouseDown()
    {
        outline.color = 1;
    }

    private void OnMouseUp()
    {
        outline.color = 0;
    }
    private void OnMouseExit()
    {
        outline.enabled = false;
    }
}
