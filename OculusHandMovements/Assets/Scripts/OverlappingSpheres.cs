using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlappingSpheres : MonoBehaviour
{
    public GameObject Tracker;
    private Vector3 TrackerPos;

    void Start()
    {
        Tracker = GameObject.Find("Tracker"); 
    }

    
    void Update()
    {
        TrackerPos = new Vector3(Tracker.transform.position.x, transform.position.y, Tracker.transform.position.z);        
        Collider[] hitColliders = Physics.OverlapSphere(TrackerPos, 5);
        //Debug.Log(Collider[]);        
    }
}
