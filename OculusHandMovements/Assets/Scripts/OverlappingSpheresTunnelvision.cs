using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
//For more comments  about this code, look to the base code called Overlapping Spheres.

public class OverlappingSpheresTunnelvision: MonoBehaviour
{
    //Getting the location of the object used in the minimap and used for the collision.
    public GameObject Tracker;
    private Vector3 TrackerPos;
    //The different radii of the colliders.
    public float radius1 = 2f;
    public float radius2 = 1.5f;
    public float radius3 = 1f;
    //k and j is simple ints used to see how many collisions happen with the colliders, i is another value which is being instanciated in the for loop
    private int k = 0;
    private int j = 0;
    //trans is the transparency factor for the vignette.
    public float trans = 0f;
    public Image vignette;
    public GameObject imageObject;

    void Start()
    {
        //vignette = this.GetComponent<Tunnel>();
        imageObject.SetActive(true);
    }


    void Update()
    {
        //Variables being reset after each iteration, this ensures the solution disables when the user is not close to a wall.
        trans = 0;
        vignette.material.color = new Color(1.0f, 1.0f, 1.0f, trans);
        j = 0;
        k = 0;
        //Continiously getting the location of the "tracker" object.
        TrackerPos = new Vector3(Tracker.transform.position.x, transform.position.y, Tracker.transform.position.z);
        //Creating three colliders for three different radii 
        Collider[] firstCollision = Physics.OverlapSphere(TrackerPos, radius1);
        Collider[] secondCollision = Physics.OverlapSphere(TrackerPos, radius2);
        Collider[] thirdCollision = Physics.OverlapSphere(TrackerPos, radius3);

        //This forloop cheks which collider has hit, if any and then does something. It checks the smallest collider first to disable the other colliders if hit.
        for (int i = 0; i < firstCollision.Length; i++)
        {
            if (k < thirdCollision.Length)
            {
                //Debug.Log(thirdCollision[k] +"K");  
                trans = 2;
                vignette.material.color = new Color(1f, 0f, 0f, trans);
                k++;
                break;
            }
            
            else if(j < secondCollision.Length)
            {
                //Debug.Log(secondCollision[j] + "J");
                trans = 1f;
                vignette.material.color = new Color(1.0f, 1.0f, 1.0f, trans);
                j++;
                break;
            }
            else if (i < firstCollision.Length)
            {
                trans = 0.8f;
                vignette.material.color = new Color(1.0f, 1.0f, 1.0f, trans);

                //Debug.Log(firstCollision[i] + "I");
                break;
            }

        }

    }
}