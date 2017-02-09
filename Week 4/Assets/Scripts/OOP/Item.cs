using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Item is a parent class.
    // Two children (TV.cs & TrashCan.cs) derive functionality and properties from it.

    // Public: Accessible to other scripts. Exposed in the Inspector.
    public float price = 10;

    // Private: Only available in this script. Not changeable by children.
    private float profit;

    // Protected: Shared between parent and child classes. Not accessible to other scripts. Not exposed in the Inspector.
    protected float discount = 5;

    public Color overColor;
    private SpriteRenderer spriteRenderer;

    // Methods which need to be modified by children must be set to either public or protected and use the virtual keyword
    protected virtual void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        profit = price * .01f;
    }

    // Private methods still work in children, but can't be modified by them
    private void OnMouseOver()
    {
        spriteRenderer.color = overColor;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = Color.white;
    }

    private void OnMouseDown()
    {
        Debug.Log("Profit from " + gameObject.name + ": " + profit);
        Destroy(gameObject);
    }
}
