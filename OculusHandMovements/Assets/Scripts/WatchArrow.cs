using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchArrow : MonoBehaviour
{
    public GameObject targetObject;
    public float speed;

    private Vector3 GameObjectPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetObject = GameObject.Find("Lightswitch");
        GameObjectPosition = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        var lookPos = GameObjectPosition - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*speed);
    }
}
