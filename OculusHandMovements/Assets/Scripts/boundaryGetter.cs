using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class boundaryGetter : MonoBehaviour
{
    // Start is called before the first frame update
    List<Vector3> boundaryPoints = new List<Vector3>();
    List<XRInputSubsystem> lst = new List<XRInputSubsystem>();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lst.Count; i++) {
            bool v = lst[i].TryGetBoundaryPoints(boundaryPoints);
            Debug.Log(v);
        }
    }
}
