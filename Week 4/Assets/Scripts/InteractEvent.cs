using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractEvent : MonoBehaviour
{
    protected Animator anim;
    public string animationParameter;

    // These will be modified in the child classes, so it is set to protected virtual
    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
    }

    protected virtual void OnEnable()
    {
        // Play audio and animation
        anim.SetBool(animationParameter, true);
    }
    protected virtual void OnDisable()
    {
        // Stop audio and animation
        anim.SetBool(animationParameter, false);
    }

}
