using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTarget : MonoBehaviour {

    public string matchingTag;
    public bool snapToCenter;

    // These are needed only in this script (private)
    private bool correct;
    private Transform snapTarget;

    // Confirm that the target is correct when the object is dropped
    private void OnMouseUp()
    {
        if (correct)
        {
            Debug.Log("Correct!");

            // If snap to center is enabled, set the position of this to the target
            if (snapToCenter)
            {
                transform.position = snapTarget.position;
            }
        }
    }

    // Check for matching tag and set the snap target position
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(matchingTag))
        {
            correct = true;
            snapTarget = collision.transform;
        }
    }

    // Reset everything when this is no longer over an object
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(matchingTag))
        {
            correct = false;

            // This will "forget" the last snap target position
            snapTarget = null;
        }
    }
}
