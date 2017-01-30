using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private bool over;

    // Mouse input from the Input class does not require a collider component.
    void Update()
    {
        // Mouse Down anywhere on the screen
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("GetMouseButtonDown");
        }

        // Mouse Up anywhere on the screen
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("GetMouseButtonUp");
        }
        // Continuous Mouse Down anywhere on the screen
        if (Input.GetMouseButton(0))
        {
            Debug.Log("GetMouseButton");
        }

        // Used with OnMouseEnter & OnMouseExit below
        if (over)
        {
            Debug.Log("Over");
        }
        else
        {
            Debug.Log("Not Over");
        }
    }

    // Direct mouse input requiring a collider component. 
    //See https://docs.unity3d.com/ScriptReference/MonoBehaviour.html under the Messages heading for more info on each. 

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }

    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("OnMouseUpAsButton");
    }

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        over = true;
    }

    private void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        over = false;
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver");
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
    }
}
