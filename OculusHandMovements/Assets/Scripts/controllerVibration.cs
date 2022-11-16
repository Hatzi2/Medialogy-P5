using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
 
public class controllerVibration : MonoBehaviour
{
    [SerializeField] XRBaseController controller;
    [SerializeField] float vibrationLength;
    [SerializeField] float vibrationStrength;
    [SerializeField] float timeBetweenVibrations;
 
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
        if (controller != null)
            controller.SendHapticImpulse(vibrationStrength, vibrationLength);
    }
}