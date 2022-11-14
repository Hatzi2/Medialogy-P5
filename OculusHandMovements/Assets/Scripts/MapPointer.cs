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
     wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
     transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
     //transform.rotation = Quaternion.RotateTowards(transform.rotation, MainCamera.transform.rotation.y, speed*Time.deltaTime);
     transform.rotation = Quaternion.Euler(0,MainCamera.transform.eulerAngles.y,0);
 }
}
