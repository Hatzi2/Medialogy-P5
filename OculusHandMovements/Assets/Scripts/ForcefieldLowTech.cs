using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldLowTech : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Wire1Low;
    public GameObject Wire2Low;
    public float transparencyLow;
    public float changeSpeedLow;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0f, 0f, transparencyLow);
        transparencyLow = Mathf.PingPong((Time.time) * changeSpeedLow, 1) + .3f;

        if(!Wire1Low.activeSelf && !Wire2Low.activeSelf){
            Destroy(gameObject);
        }
    }
}
