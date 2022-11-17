using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class OverlappingSpheresAudio : MonoBehaviour
{
    public colliderAudioPlayer audioPlayer;
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
                audioPlayer.sendBeeps(true, 3);
                k++;
                break;
            }
            
            else if(j < secondCollision.Length)
            {
                audioPlayer.sendBeeps(true, 2);
                j++;
                break;
            }
            else if (i < firstCollision.Length)
            {
                audioPlayer.sendBeeps(true, 1);
                break;
            }

        }

    }
}