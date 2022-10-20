using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FuseBox : MonoBehaviour
{
    public GameObject fuseSocket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.z != 0)
        {
            fuseSocket.SetActive(true);
        }
        else
        {
            fuseSocket.SetActive(false);
        }
    }
}
