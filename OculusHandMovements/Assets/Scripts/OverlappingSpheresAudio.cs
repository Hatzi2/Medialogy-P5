using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class OverlappingSpheresAudio : MonoBehaviour
{
    public GameObject Tracker;
    private Vector3 TrackerPos;
    public float radius1 = 2f;
    public float radius2 = 1.5f;
    public float radius3 = 1f;
    private int k = 0;
    private int j = 0;

    void Start()
    {

    }


    void Update()
    {
        j = 0;
        k = 0;
        TrackerPos = new Vector3(Tracker.transform.position.x, transform.position.y, Tracker.transform.position.z);
        Collider[] firstCollision = Physics.OverlapSphere(TrackerPos, radius1);
        Collider[] secondCollision = Physics.OverlapSphere(TrackerPos, radius2);
        Collider[] thirdCollision = Physics.OverlapSphere(TrackerPos, radius3);

        for (int i = 0; i < firstCollision.Length; i++)
        {
            if (k < thirdCollision.Length)
            {
                Debug.Log(thirdCollision[k] +"K");
                k++;

                break;
            }
            
            else if(j < secondCollision.Length)
            {
                Debug.Log(secondCollision[j] + "J");
                j++;
                break;
            }
            else if (i < firstCollision.Length)
            {
                Debug.Log(firstCollision[i] + "I");
                break;
            }

        }

    }

void OnDrawGizmosSelected ()
 {
     Gizmos.color = Color.green;
     Gizmos.DrawWireSphere (transform.position, radius1);
     Gizmos.color = Color.yellow;
     Gizmos.DrawWireSphere (transform.position, radius2);
     Gizmos.color = Color.red;
     Gizmos.DrawWireSphere (transform.position, radius3);
 }
}