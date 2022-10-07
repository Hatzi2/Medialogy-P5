using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSpawner : MonoBehaviour
{
    private BoxCollider wire;
    public GameObject lightswitch;
    // Start is called before the first frame update
    void Start()
    {
        wire = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightswitch == null)
        {
            wire.enabled = true;
        }
        else
        {
            wire.enabled = false;
        }
    }
}
