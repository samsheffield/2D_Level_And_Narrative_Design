using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVEvent : InteractEvent {

	// Use this for initialization
	public override void Start () {
        message = "car";
	}

    private void OnEnable()
    {
        Debug.Log("DO THIS");
    }
}
