using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPointer : MonoBehaviour
{
private GameObject wayPoint;
 private Vector3 wayPointPos;
 private float speed = 20.0f;
 void Start ()
 {
      wayPoint = GameObject.Find("wayPoint");
 }
 
 void Update ()
 {
      wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
      transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
 }
}