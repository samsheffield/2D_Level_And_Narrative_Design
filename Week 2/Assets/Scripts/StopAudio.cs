using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour
{

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioManager.instance.audioSource.Stop();
        }

    }
}
