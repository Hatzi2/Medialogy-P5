using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights;
    public Light blacklight;
    public GameObject Wire1;
    public GameObject Wire2;

    public void turnOn(bool on)
    {
       for (int i = 0; i < lights.Length; i++)
            {
                lights[i].enabled = on;
            } 
        blacklight.enabled = !on;
    }

}
