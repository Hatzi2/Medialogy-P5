using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Follower : MonoBehaviour
{
    int speed = 5;
    private GameObject playerPos;
    private Vector3 playerPosition;
    private Vector3 ducklingPos;
    private int i;
    private bool follow;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("Olimar");
    
    }

    // Update is called once per frame
    void Update()
    {
        
        playerPosition = new Vector3(playerPos.transform.position.x+1, transform.position.y, playerPos.transform.position.z);
        
        ducklingPos = new Vector3(Input.GetAxis("Horizontal")*speed,0,Input.GetAxis("Vertical")*speed);
        
        float distance = Vector3.Distance(playerPosition, transform.position);
        
        if(distance < 10)
        {
            follow = true;
        }
        
        if(follow == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        }
    }

}