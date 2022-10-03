using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcefield : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Wire1;
    public GameObject Wire2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!Wire1.activeSelf && !Wire2.activeSelf){
            Destroy(gameObject);
        }
    }
}
