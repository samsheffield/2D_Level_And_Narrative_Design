using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    // This holds the transform position from the previous frame. It is a Vector3 to match transform.position
    private Vector3 lastPosition;

    // This holds the last direction the sprite was facing. It is a Vector2 since we only need the x & y values 
    private Vector2 lastDirection;

    // This is used to switch between the two animation blend trees
    private bool isMoving;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Reset isMoving to false as a default when there is no input
        isMoving = false;

        if (transform.position != lastPosition)
        {
            isMoving = true;
            // Movement is the difference between the current position and the last position
            Vector2 move = transform.position - lastPosition;

            // Set the float parameters in the animator
            anim.SetFloat("MoveX", move.x);
            anim.SetFloat("MoveY", move.y);

            // Save the last movement as the facing direction
            lastDirection = move;

            // Set the LastMove parameter in the animator. This will be used by the Idle blend tree
            anim.SetFloat("LastMoveX", lastDirection.x);
            anim.SetFloat("LastMoveY", lastDirection.y);
        }

        // Set the IsMoving parameter in the animator. This will switch between Movement and Idle blend states
        anim.SetBool("IsMoving", isMoving);
    }

    private void LateUpdate()
    {
        // Save the last position of the transform
        lastPosition = transform.position;
    }
}
