using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emergencylight : MonoBehaviour
{
    public GameObject Wire1;
    public GameObject Wire2;
    public Light thisLight;
    public AudioSource Emergency;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!Wire1.activeSelf && !Wire2.activeSelf){
            float Timer = Mathf.PingPong(Time.time*2, 2);
            Emergency.Play();
            if (Timer > 1)
            {
                thisLight.enabled = false;
            }
            else
            {
                thisLight.enabled = true;
            }
        }
    }
}
