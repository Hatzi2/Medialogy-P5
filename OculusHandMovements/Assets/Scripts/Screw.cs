using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour
{
    public float unscrewLength = 0.01f;
    public GameObject currentScrew;
    public AudioSource ScrewSound;

    private float unscrewTime = 0.2f;
    private float duration;

    void Update()
    {
        while(duration < unscrewTime){
            duration += Time.deltaTime;
            transform.position = transform.position + new Vector3(-1 * unscrewLength * Time.deltaTime, 0, 0);
            transform.Rotate(Vector3.right, 25.0f * Time.deltaTime, Space.World);
            ScrewSound.Play();
            currentScrew.GetComponent<Rigidbody>().useGravity = true;
            Destroy(currentScrew, 1);
        }
    }
}