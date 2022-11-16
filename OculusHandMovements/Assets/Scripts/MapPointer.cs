using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPointer : MonoBehaviour
{
     
 private GameObject wayPoint;
 private Vector3 wayPointPos;
 private GameObject MainCamera;

 private float speed = 20.0f;
 
 void Start ()
 {
      wayPoint = GameObject.Find("wayPoint");
      MainCamera = GameObject.Find("Main Camera");
 }
 
 void Update ()
 {   
<<<<<<< HEAD
    InputTracking.GetNodeStates(nodeStates);
    var headState = nodeStates.FirstOrDefault(node => node.nodeType == XRNode.Head);
    
    //headState.TryGetPosition(out headPosition);
    headState.TryGetRotation(out headRotation);
    
    //Debug.Log(headRotation[0]);
    //UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.Head, HeadOrientation);
    wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
    transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    //HeadOrientation = HeadOrientation[0].transform.localRotation.y;
    //test = new Vector3(UnityEngine.XR.XRNode.Head.x, UnityEngine.XR.XRNode.Head.y, UnityEngine.XR.XRNode.Head.z);

    //test = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
    //Debug.Log(UnityEngine.XR.InputTrackingState.Rotation);
    //transform.rotation = Quaternion.RotateTowards(transform.rotation, MainCamera.transform.rotation.y, speed*Time.deltaTime);

    transform.rotation = Quaternion.Euler(0,headRotation[1]*180,0);
=======
     wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
     transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
     //transform.rotation = Quaternion.RotateTowards(transform.rotation, MainCamera.transform.rotation.y, speed*Time.deltaTime);
     transform.rotation = Quaternion.Euler(0,MainCamera.transform.eulerAngles.y,0);
>>>>>>> parent of 74e9183 (Added rotation that actually works)
 }
}
