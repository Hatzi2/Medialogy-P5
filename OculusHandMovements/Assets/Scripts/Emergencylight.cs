using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emergencylight : MonoBehaviour
{
    public GameObject Wire1;
    public GameObject Wire2;
    public Light thisLight;
    public AudioSource Emergency;

    void Update()
    {
        if(!Wire1.activeSelf && !Wire2.activeSelf){
            Emergency.loop = true;
            float Timer = Mathf.PingPong(Time.time*2, 2);
            if (Timer > 1)
            {
                thisLight.enabled = false;
                Emergency.Play();
            }
            else
            {
                thisLight.enabled = true;
            }
        }
    }
}
