using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlappingSpheres : MonoBehaviour
{
    public GameObject Tracker;
    private Vector3 TrackerPos;
    public float radius = 5.0f;

    void Start()
    {
        Tracker = GameObject.Find("Tracker"); 
    }

    
    void Update()
    {
        TrackerPos = new Vector3(Tracker.transform.position.x, transform.position.y, Tracker.transform.position.z);        
        Collider[] hitColliders = Physics.OverlapSphere(TrackerPos, radius);

        for (int i = 0; i < hitColliders.Length; i++)
        {
            Debug.Log(hitColliders[i]);
        }
        
        
        
        /*if (i < hitColliders.Length)
        {
            i++;
            Debug.Log(hitColliders[0]);
            if (i < hitColliders.Length)
            {
                Debug.Log(hitColliders[1]);
            }
        }     */   
    }
    void OnDrawGizmosSelected ()
 {
     Gizmos.color = Color.white;
     Gizmos.DrawWireSphere (transform.position, radius);
 }
}
