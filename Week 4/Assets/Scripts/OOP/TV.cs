using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : Item
{

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        Test();
    }

    private void Test()
    {
        Debug.Log("TEST");
    }

    private void OnMouseOver()
    {
        Destroy(gameObject);
    }
}
