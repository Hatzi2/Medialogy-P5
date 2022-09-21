using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Follower : MonoBehaviour
{
    int speed = 5;
    private GameObject playerPos;
    private GameObject enemyPos;
    private Vector3 playerPosition;
    private Vector3 ducklingPos;
    private Vector3 enemyPosition;
    private int i;
    private bool follow;
    private bool followOnce;

    // Start is called before the first frame update
    void Start()
    {
        followOnce = true;
        playerPos = GameObject.Find("Olimar");
        enemyPos = GameObject.Find("Enemy");
    
    }

    // Update is called once per frame
    void Update()
    {
        
        playerPosition = new Vector3(playerPos.transform.position.x+1, transform.position.y, playerPos.transform.position.z);
        
        enemyPosition = new Vector3(enemyPos.transform.position.x, enemyPos.transform.position.y, enemyPos.transform.position.z);

        ducklingPos = new Vector3(Input.GetAxis("Horizontal")*speed,0,Input.GetAxis("Vertical")*speed);
        
        float distance = Vector3.Distance(playerPosition, transform.position);
        
        //Debug.Log(distance);
        
        if((distance < 10) && followOnce == true) 
        {
            follow = true;
            followOnce = false;
        }
        
        if(follow == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        }
        if((Input.GetKey(KeyCode.Space)&& followOnce == false))
        {
            follow = false;
            speed = 50;
            transform.position = Vector3.MoveTowards(transform.position, enemyPosition, speed * Time.deltaTime);
            
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            speed = 5;
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name.Equals ("Enemy"))
        {
            Debug.Log("hej");
            
            Destroy(gameObject);
        }
    }

}