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
        // Check if correct input is given based on whether the continuous variable is set true or false.
        // Set the target position to the converted mouse position
        if ( Input.GetMouseButtonDown(0) || (Input.GetMouseButton(0) && continuous) )
        {
            Vector3 newMousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
            target = Camera.main.ScreenToWorldPoint(newMousePosition);
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
