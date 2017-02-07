using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractEvent : MonoBehaviour
{

    protected Animator anim;
    public string animationParameter;

    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
    }

}
