using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2D : MonoBehaviour
{
    private Vector3 offset;
    private SpriteRenderer spriteRenderer;

    // Static variables belong to the class, not the gameobject instance
    // This allows them to be shared amongst all members of the class (any gameobject with this component attached)
    private static int currentSortingOrder;
    private static GameObject lastSelected;

    void Start()
    {
        // Sprite renderer component manages the sorting order for a sprite
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the currentsorting order to the current one. 
        // Note: This is a static variable, so all members will be set to the value of the last one added. Make sure they are all the same to start with. 
        currentSortingOrder = spriteRenderer.sortingOrder;
    }

    private void OnMouseDown()
    {
        // Offest the mouse position so that the object can be grabbed anywhere
        // ScreenToWorldPoint will convert the coordinates on the screen to something relative to the space in your scene
        // -Camera.main.transform.position.z will keep the object's z position from changing to the camera's z position
        Vector3 newMousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
        offset = transform.position - Camera.main.ScreenToWorldPoint(newMousePosition);

        // This check is to reduce how often the sorting order is increased
        // Check if the last selected gameobject with the DragDrop2D component was this one. If not...
        if (lastSelected != gameObject)
        {
            // Increase the sorting order for all gameobjects with the DragDrop2D component
            currentSortingOrder++;
            spriteRenderer.sortingOrder = currentSortingOrder;

            // Make the last selected gameobject this one
            lastSelected = gameObject;
        }
    }

    // When dragging, follow the mouse position + offset
    private void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
}
