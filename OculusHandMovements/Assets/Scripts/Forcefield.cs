using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcefield : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Wire1;
    public GameObject Wire2;
    public float transparency;
    public float changeSpeed;

    public AudioSource ForceFieldSound;
    public AudioSource ForceFieldTerminateSound;

    
    void Start()
    {
        ForceFieldSound.loop = true;
        ForceFieldSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0f, 0f, transparency);
        transparency = Mathf.PingPong((Time.time) * changeSpeed, 1) + .3f;

        if(!Wire1.activeSelf && !Wire2.activeSelf){
            ForceFieldSound.Stop();
            ForceFieldTerminateSound.Play();
            Destroy(gameObject);
        }
    }
}
