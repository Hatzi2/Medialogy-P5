using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchArrow : MonoBehaviour
{
    public GameObject targetObject;
    public float maxDistance;
    private float speed = 100;
    private Vector3 GameObjectPosition;
    Color colorStart = Color.cyan;
    Color colorEnd = Color.red;
    Renderer rend;
    Renderer watchScreenMat;

    void Start()
    {
        var watchScreen = GameObject.Find("Screen");
        watchScreenMat = watchScreen.GetComponent<Renderer>();
        rend = GetComponent<Renderer>();
        GameObjectPosition = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z);
    }

    void Update()
    {
        float distance = Vector3.Distance (this.transform.position, targetObject.transform.position);
        rend.material.color = Color.Lerp(colorStart, colorEnd, distance/maxDistance);
        watchScreenMat.material.SetColor("_EmissionColor", Color.Lerp(colorStart, colorEnd, distance/maxDistance));
        var watchLight = GameObject.Find("Watch Light").GetComponent<Light>();
        watchLight.color = Color.Lerp(colorStart, colorEnd, distance/maxDistance);
        var lookPos = GameObjectPosition - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*speed);
    }
}
