using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour
{
    public float speed = 0.1f;
    public float duration;
    //public Vector3 target = new Vector3(0,0,2);
    //public float xAngle, yAngle, zAngle;
    //[SerializeField] private Vector3 rotation;
    //[SerializeField] private float speed;
    //[SerializeField] private float movementspeed;
    //public float degreesPerSecond = 2.0f;
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //Debug.Log(duration);
        //duration = Time.time;
        while(duration < 0.2f){
            duration += Time.deltaTime;
            Debug.Log(duration);
            transform.position = transform.position + new Vector3(-1 * speed * Time.deltaTime, 0, 0);
            transform.Rotate(Vector3.right, 25.0f * Time.deltaTime, Space.World);
        }
    }
}