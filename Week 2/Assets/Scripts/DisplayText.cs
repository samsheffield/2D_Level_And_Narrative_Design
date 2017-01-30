using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    // Set this to the UI Text you want to use
    public Text messageText;

    // These are the messages you want to display in the messageText
    public string[] messages;

    // Set this to true if you want to display text when you roll over this gameobject
    public bool resetOnMouseOver;

    // You'll need an AutoType component attached to your UI Text to use these
    [Header("Auto Type")]

    // Set this to true if you want to use auto type
    public bool useAutoType;

    // Set this to true to start auto typing without input
    public bool playOnStart;

    private AutoType autoType;
    private int currentMessage;

    private void Start()
    {
        // Find the autotype component if it's being used. Start playing if playOnStart is true.
        if (useAutoType)
        {
            autoType = messageText.GetComponent<AutoType>();
            if (playOnStart)
            {
                UpdateText();
            }
        }
    }

    private void OnMouseEnter()
    {
        // If resetOnMouseOver is true, display new text when the mouse enters
        if (resetOnMouseOver)
        {
            UpdateText();
        }
    }

    private void OnMouseExit()
    {
        // Reset currentMessage unless playOnStart is true
        if (!playOnStart)
            currentMessage = 0;
    }

    private void OnMouseDown()
    {
        // Use UpdateText to cycle through messages. Can be called from other scripts or without mouse input
        UpdateText();
    }

    // Cycle through messages, display or autotype them, and reset when necessary
    public void UpdateText()
    {
        if (useAutoType)
        {
            autoType.Reset(messages[currentMessage]);
        }
        else
        {
            messageText.text = messages[currentMessage];
        }

        if (currentMessage < messages.Length - 1)
        {
            currentMessage++;
        }
        else
        {
            currentMessage = 0;
        }
    }

}
