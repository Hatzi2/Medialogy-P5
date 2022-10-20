using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Light roomLight;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.localEulerAngles.x == 45)
        {
            roomLight.enabled = true;
            Debug.Log("Lever Down");
        }
        if (transform.localEulerAngles.x == 315)
        {
            roomLight.enabled = false;
            Debug.Log("Lever Up");
        }
    }
}
