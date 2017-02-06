using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Transform stopLocation;
    public InteractEvent interactEvent;
    public bool disableOnExit;
    private Transform player;
    private bool arrived;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

   /* private void Update()
    {
        if (Mathf.Abs(Vector3.Distance(stopLocation.position, player.position)) < .1f)
        {
            if (!arrived)
            {
                arrived = true;
                EnableEvent();
            }
        }
        else
        {
            if (disableOnExit)
            {
                arrived = false;
                DisableEvent();
                
            }
            
        }
    }*/

    public void EnableEvent()
    {
        interactEvent.enabled = true;
    }

    public void DisableEvent()
    {
        interactEvent.enabled = false;
    }
}
