using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashEvent : InteractEvent
{

    private void OnEnable()
    {
        anim.SetBool("onFire", true);
    }
    private void OnDisable()
    {
        anim.SetBool("onFire", false);

    }
}
