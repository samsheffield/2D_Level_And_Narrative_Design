using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVEvent : InteractEvent {
    private AudioSource audioSource;
    public AudioClip tvAudio;

    protected override void Awake()
    {
        base.Awake();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = tvAudio;
    }

    private void OnEnable()
    {
        audioSource.Play();
        anim.SetBool("tvFlicker", true);
    }
    private void OnDisable()
    {
        audioSource.Stop();
        anim.SetBool("tvFlicker", false);
    }
}
