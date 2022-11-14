using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadSoundScript : MonoBehaviour
{
    public AudioSource keyaudio;

    public void playButton()
    {
        GetComponent<AudioSource>().Play();
    }
        
    }
