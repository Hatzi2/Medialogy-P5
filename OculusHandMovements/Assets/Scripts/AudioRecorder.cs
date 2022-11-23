using UnityEngine;

public class AudioRecorder : MonoBehaviour
{
    // Start recording with built-in Microphone and play the recorded audio right away
    void Start()
    {
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
        }
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start("Headset Microphone (Oculus Virtual Audio Device)", true, 10, 44100);
        audioSource.Play();
    }
}