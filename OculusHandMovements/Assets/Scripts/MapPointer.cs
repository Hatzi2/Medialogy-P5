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
     private float speed = 20.0f;
 
 void Start ()
 {
      wayPoint = GameObject.Find("wayPoint");
 }
 
 void Update ()
 {   
    InputTracking.GetNodeStates(nodeStates);
    var headState = nodeStates.FirstOrDefault(node => node.nodeType == XRNode.Head);
    headState.TryGetPosition(out headPosition);
    wayPointPos = new Vector3(headPosition[0], -10, headPosition[2]);
    transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
 }
}
