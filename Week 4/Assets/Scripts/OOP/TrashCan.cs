using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Default parent class is MonoBehaviour
public class TrashCan : Item
{
    
    // No Awake? If you don't need to make any changes to a parent's method, you don't need to call it in the child

    // A parent's private method can be replaced by creating a new private method with the same name in a child
    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " is not currently for sale");
    }
}
