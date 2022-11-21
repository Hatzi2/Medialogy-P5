using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderAudioPlayer : MonoBehaviour
{
    public AudioSource beep;
    void Start()
    {
        beep.loop = true;
        beep.Play();
    }

    public void sendBeeps(float volume)
    {
            beep.volume = volume;
    }
}
