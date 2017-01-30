using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Setting this to true will force any existing AudioManager to be destroyed
    public bool forceDestroy;

    // Singleton pattern: You should have only one of these in your project. It can be referred to as AudioManager.instance
    public static AudioManager instance;

    [HideInInspector]
    public AudioSource audioSource;

    private void Awake()
    {
        // Singleton pattern: If there is not already an instance of this, make the instance this one...
        // If there is an instance, but it's not this, destroy this gameobject
        // UNLESS... you use forceDestroy. Then the other instance will be destroyed
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            if (forceDestroy)
            {
                Destroy(instance.gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        // Use this to make the gameobject persistent between scenes
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

}
