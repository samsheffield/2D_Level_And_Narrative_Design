// Modified from here: http://wiki.unity3d.com/index.php?title=AutoType
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour
{
    // The typing rate for each letter
    public float letterDelay = 0.05f;

    // Add an audioclip for typewriter sound
    public AudioClip sound;

    // Be sure to add an audiosource component to your this gameobject if you want sound
    private AudioSource audioSource;

    // This will hold the message to type
    private string message;

    // This is the Text component attached to this gameobject
    private Text messageText;

    void Awake()
    {
        messageText = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }

    // Use this to pass new messages to auto type
    public void Reset(string newMessage)
    {
        message = newMessage;

        // Clear the messageText to start over
        messageText.text = "";

        // Stop any TypeText coroutines, then start a new one
        StopAllCoroutines();
        StartCoroutine(TypeText());
    }

    // Typewriter effect
    IEnumerator TypeText()
    {
        // Break up the string into a character array and then go through each character
        foreach(char letter in message.ToCharArray())
        {
            // Update the UI Text with each letter
            messageText.text += letter;

            // Play sound, if it is set.
            if (sound)
            {
                audioSource.PlayOneShot(sound);
            }

            yield return new WaitForSeconds(letterDelay);
        }
    }


}
