using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public GameObject PLight;
    void Start()
    {
        
    }
    //Måske lav det sådan at der er en count der går up hver gang knappen bliver "grabbed" og resetter tilbage når if statement bliver kørt, 
    //på den måde activeres scripted og overwriter den initial GameObjectSetActive i grab interact controlleren kun hver anden gang der bliver
    //trykket? Altså så vil lyset tænde der me thinks, har ikk et headset så kan ikk lige teste noget - Mads 12-10-2022
    void Update()
    {
        if(!PLight.activeSelf){
            PLight.SetActive(true);
        }
    }
}
