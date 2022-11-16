using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class controllerVibration : MonoBehaviour
{
    public XRBaseController LController;
    public XRBaseController RController;
    public float vibrationLength;
    public float vibrationStrength;
    public float timeBetweenVibrations;
 
    protected void Start()
    {
        StartCoroutine(StartPeriodicHaptics());
    }
 
    IEnumerator StartPeriodicHaptics()
    {
        var delay = new WaitForSeconds(timeBetweenVibrations);
 
        while (true)
        {
            yield return delay;
            SendHaptics();
        }
    }
 
    void SendHaptics()
    {
        
        RController.SendHapticImpulse(vibrationStrength, vibrationLength);
        LController.SendHapticImpulse(vibrationStrength, vibrationLength);
    }
}