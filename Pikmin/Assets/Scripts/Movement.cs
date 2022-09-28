using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    private CharacterController characterController;
   // public float speed = 5f;
    public float _rotationSpeed = 180;
    public float _speed = 10;

    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), -1, Input.GetAxis("Vertical"));

        //characterController.Move(move*Time.deltaTime*speed); 

        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
 
        Vector3 move = new Vector3(0, -1, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        
        move = this.transform.TransformDirection(move);
        characterController.Move(move * _speed);
        this.transform.Rotate(this.rotation);
    }
}