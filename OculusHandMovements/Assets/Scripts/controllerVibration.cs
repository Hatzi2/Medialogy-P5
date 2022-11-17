using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class controllerVibration : MonoBehaviour
{
    public XRBaseController LController;
    public XRBaseController RController;
    public float timeBetweenVibrations;
 
    protected void Start()
    {
        StartCoroutine(StartPeriodicHaptics());
    }
 
    public IEnumerator StartPeriodicHaptics()
    {
        var delay = new WaitForSeconds(timeBetweenVibrations);
 
        while (true)
        {
            yield return delay;
            SendHaptics(0, 0);
        }
    }
 
    public void SendHaptics(float vibrationStrength, float vibrationLength)
    {
        
        RController.SendHapticImpulse(vibrationStrength, vibrationLength);
        LController.SendHapticImpulse(vibrationStrength, vibrationLength);
    }
}