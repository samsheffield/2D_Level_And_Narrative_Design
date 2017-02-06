using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToClick : MonoBehaviour
{
    public float speed = 10f;
    // Allow for continuous input? 
    public bool continuous;
    private Vector3 target;

    // Requires the Navigation2D Unity Asset ($10)
    private NavMeshAgent2D navMesh2D;
    public bool usingNavMesh2D;

    public Interactable currentInteractable;
    private bool arrived;


    private void Start()
    {
        target = transform.position;

        // If you want to use Navigation2D, you'll need to set this to true in the inspector
        if (usingNavMesh2D)
        {
            navMesh2D = GetComponent<NavMeshAgent2D>();
        }
    }

    void Update()
    {

        if (currentInteractable != null)
        {
            if (Mathf.Abs(Vector3.Distance(transform.position, target)) < .1f)
            {
                if (!arrived)
                {
                    arrived = true;
                    currentInteractable.EnableEvent();
                }
            }
            else
            {
                arrived = false;
            }
        }

        if (!arrived)
        {
            if (currentInteractable != null)
            {
                if (currentInteractable.disableOnExit)
                    currentInteractable.DisableEvent();

            }
        }
        // Check if correct input is given based on whether the continuous variable is set true or false.
        // Set the target position to the converted mouse position
        if (Input.GetMouseButtonDown(0) || (Input.GetMouseButton(0) && continuous))
        {

            //currentInteractable = null;

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.CompareTag("Interactable"))
                {
                    currentInteractable = hit.collider.GetComponent<Interactable>();
                }
            }

            // Set target for movement

            if (currentInteractable != null)
            {
                target = currentInteractable.stopLocation.position;
            }
            else
            {
                currentInteractable = null;
                Vector3 newMousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
                target = Camera.main.ScreenToWorldPoint(newMousePosition);
            }

        }

        // Move towards target based on whether NavMesh2D is being used or not
        if (usingNavMesh2D)
        {
            // Set the navmesh agent's target position using .destination
            navMesh2D.destination = target;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
}
