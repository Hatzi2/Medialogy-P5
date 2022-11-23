using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR;
using System.Linq;
using Unity.Mathematics;
public class MapPointer : MonoBehaviour
{
     private GameObject wayPoint;
     private Vector3 wayPointPos;
    private Vector3 headPosition;
    private Quaternion headRotation;
    private Vector3 headPositionPos;
    private List<XRNodeState> nodeStates = new List<XRNodeState>();
    //private Vector3 reMappedValue;
     //public GameObject MainCamera;
     //List<InputDevice> HeadOrientation = new List<InputDevice>(); 
     private float speed = 20.0f;
 
 void Start ()
 {
      wayPoint = GameObject.Find("wayPoint");
      //MainCamera = GameObject.Find("Main Camera");

      
 }
 
 void Update ()
 {   
    InputTracking.GetNodeStates(nodeStates);
    var headState = nodeStates.FirstOrDefault(node => node.nodeType == XRNode.Head);
    
    headState.TryGetPosition(out headPosition);
    //headState.TryGetRotation(out headRotation);

    //reMappedValue = new Vector3(0, headRotation[1], 0);
    //transform.localEulerAngles = reMappedValue;
    //Debug.Log(transform.localEulerAngles.y);
    //headRotation.eulerAngles = reMappedValue;

    //UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.Head, HeadOrientation);
    wayPointPos = new Vector3(headPosition[0], -10, headPosition[2]);
    transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    
    //HeadOrientation = HeadOrientation[0].transform.localRotation.y; 
    //test = new Vector3(UnityEngine.XR.XRNode.Head.x, UnityEngine.XR.XRNode.Head.y, UnityEngine.XR.XRNode.Head.z);

    //test = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
    //Debug.Log(UnityEngine.XR.InputTrackingState.Rotation);
    //transform.rotation = Quaternion.RotateTowards(transform.rotation, MainCamera.transform.rotation.y, speed*Time.deltaTime);

    //transform.rotation = Quaternion.eulerAngles(0,headRotation[1],0);
    //transform.rotation = headRotation;
    //Debug.Log(headRotation);
    //headPositionPos = new Vector3(headPosition.x,0,headPosition.z);
    //transform.position = Vector3.MoveTowards(headPositionPos, headPositionPos, speed * Time.deltaTime);
 }

}
