using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderAudioPlayer : MonoBehaviour
{
    public AudioSource beep;
    void Start()
    {

    }

    public void sendBeeps(bool playing, float pitch)
    {
        if (playing)
        {
            beep.Play();
            beep.loop = true;
            beep.pitch = pitch;
        }
        else
        {
            beep.Stop();
        }
    }
}
