using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldPulsing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<MeshRenderer>().material.color=new Color(1.0f, 0f, 0f, 0.0f);
    }
}
