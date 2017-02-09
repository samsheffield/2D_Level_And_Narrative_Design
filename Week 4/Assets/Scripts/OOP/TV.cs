using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Change MonoBehaviour to the class you want to inherit from
public class TV : Item
{
    // Use the same access modifier as the parent (protected here)
    // Use the override keyword to change the functionality from its parent's method (parent method must be set to virtual)
    protected override void Awake()
    {
        // Use base. plus the method name to call the parent method
        base.Awake();

        // Make changes as usual
        discount = 50;
        Debug.Log("Update discount for " + gameObject.name + ": " + discount);
        
    }
}
