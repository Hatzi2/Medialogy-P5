using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x == -45f)
        {
            Debug.Log("Lever Down");
        }
        if (transform.eulerAngles.x == 45f)
        {
            Debug.Log("Lever Up");
        }

    }
}
