using UnityEngine;

public class AudioRecorder : MonoBehaviour
{
    public GameObject endState;
    AudioClip myAudioClip; 
    public bool ManualSave = false;
    private bool saved = false;
    void Start()
    {
        myAudioClip = Microphone.Start("Headset Microphone (Oculus Virtual Audio Device)", true, 1200, 44100);
    }

    void Update(){
        var curTime = "";
        if (endState.activeSelf && saved == false|| ManualSave)
        {
            curTime = System.DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss");
            Microphone.End("Headset Microphone (Oculus Virtual Audio Device)");
            SavWav.Save("AudioRecording"+curTime, myAudioClip);
            saved = true;
        }
    }
}