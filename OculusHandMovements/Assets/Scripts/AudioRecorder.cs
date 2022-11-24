using UnityEngine;

public class AudioRecorder : MonoBehaviour
{
    public GameObject endState;
    public bool saveState = false;
    AudioClip myAudioClip; 
    void Start()
    {
        myAudioClip = Microphone.Start("Headset Microphone (Oculus Virtual Audio Device)", true, 100, 44100);
    }

    void Update(){
        if (saveState)
        {
            Microphone.End("Headset Microphone (Oculus Virtual Audio Device)");
            SavWav.Save("myfile", myAudioClip);
        }
    }
}