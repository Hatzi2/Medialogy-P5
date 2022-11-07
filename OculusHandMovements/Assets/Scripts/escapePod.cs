using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapePod : MonoBehaviour
{
    public Lever[] Levers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool allPulled() {
        for ( int i = 0; i < Levers.Length; ++i ) {
             if (Levers[i].isMax == false ) {
                return false;
            }
        }
        return true;
 }
            if(allPulled())
            {
                this.transform.position = new Vector3(0,0,2);
                Debug.Log("Open");
            }
    }
}
