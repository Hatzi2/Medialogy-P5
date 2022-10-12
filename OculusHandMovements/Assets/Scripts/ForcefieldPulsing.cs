using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcefieldPulsing : MonoBehaviour
{
    // Start is called before the first frame update
    public float transparency;
    public float changeSpeed;

    public AudioSource ForceFieldSound;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 0f, 0f, transparency);
        transparency = Mathf.PingPong((Time.time) * changeSpeed, 1) + .3f;
        ForceFieldSound.Play();
    }
}
