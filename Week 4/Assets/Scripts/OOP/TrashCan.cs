using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : Item {

    protected override void Start()
    {
        base.Start();
    }

    protected new void Update()
    {
        Debug.Log("Points " + points);
    }
}
