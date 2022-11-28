using UnityEngine;

public class AudioRecorder : MonoBehaviour
{
    public GameObject endState;
    AudioClip myAudioClip; 
    void Start()
    {
        myAudioClip = Microphone.Start("Headset Microphone (Oculus Virtual Audio Device)", true, 1200, 44100);
    }

    void Update(){
        if (endState.activeSelf)
        {
            Microphone.End("Headset Microphone (Oculus Virtual Audio Device)");
            SavWav.Save("myfile", myAudioClip);
        }
    }
}