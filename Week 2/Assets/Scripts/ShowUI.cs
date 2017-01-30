using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    // The gameobject you want to enable/disable
    public GameObject uiCanvas;

    // Set the booleans for the desired interaction
    // Show on mouse over
    public bool onMouseOver;

    // Show on mouse click
    public bool onMouseDown;

    private void OnMouseDown()
    {
        if (onMouseDown)
        {
            uiCanvas.SetActive(true);
        }
    }

    private void OnMouseEnter()
    {
        if (onMouseOver)
        {
            uiCanvas.SetActive(true);
        }
    }

    // Always close gameobject on mouse exit
    private void OnMouseExit()
    {
        uiCanvas.SetActive(false);
    }
}
