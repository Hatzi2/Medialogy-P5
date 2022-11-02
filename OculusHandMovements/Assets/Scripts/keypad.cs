using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour
{
    public string outputNumber;
    public keypadScreen screen;

    void OnCollisionEnter(Collision collision)
    {
        screen.writeToScreen(outputNumber);
    }
}
