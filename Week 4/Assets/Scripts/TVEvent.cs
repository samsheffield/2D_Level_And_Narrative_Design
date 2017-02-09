using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inherit from the InteractEvent class
public class TVEvent : InteractEvent
{

    private AudioSource audioSource;
    public AudioClip tvAudio;

    // Modify the parent's virtual methods with override + base.
    protected override void Awake()
    {
        // Extend base class
        base.Awake();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = tvAudio;
    }

    protected override void OnEnable()
    {
        // Play audio and animation
        base.OnEnable();
        audioSource.Play();
    }
    protected override void OnDisable()
    {
        // Stop audio and animation
        base.OnDisable();
        audioSource.Stop();
    }
}
