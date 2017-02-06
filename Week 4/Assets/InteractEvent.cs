using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractEvent : MonoBehaviour {

    protected string message;
	// Use this for initialization
	public virtual void Start () {
        message = "base";
	}
	
	// Update is called once per frame
	public virtual void Update () {
        //Debug.Log(message);
	}
}
