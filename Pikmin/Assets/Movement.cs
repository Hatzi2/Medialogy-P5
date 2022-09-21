
using UnityEngine;

public class Movement : MonoBehaviour

{
    private CharacterController characterController;
    public float speed = 5f;
    public float rotationspeed = 150f;
    // Start is called before the first frame update
    private Vector3 Rotation;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float gravity = -0.01f;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10f;
        }
                
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }
        
        


        this.Rotation = new Vector3(0, Input.GetAxis("Mouse X")*rotationspeed*Time.deltaTime, 0);

        Vector3 move = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime, gravity,  Input.GetAxis("Vertical")*Time.deltaTime);
    

        move = this.transform.TransformDirection(move);
        characterController.Move(move*speed); 
        this.transform.Rotate(this.Rotation);


    }
}
