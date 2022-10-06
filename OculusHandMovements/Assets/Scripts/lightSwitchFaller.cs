using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitchFaller : MonoBehaviour
{
    public Screw[] screws;
    public GameObject lightswitch;

    void Start()
    {
        Rigidbody gameObjectsRigidBody = lightswitch.GetComponent<Rigidbody>();
        gameObjectsRigidBody.isKinematic = true;
    }

    void Update()
    {
        if (screws[0] == null && screws[1] == null && screws[2] == null && screws[3] == null)
        {
            lightswitch.GetComponent<Rigidbody>().isKinematic = false;
            lightswitch.GetComponent<Rigidbody>().useGravity = true;
            Destroy(lightswitch, 2);
        }
        
    }
}
