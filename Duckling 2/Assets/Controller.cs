
using UnityEngine;

public class Controller : MonoBehaviour

{
    private CharacterController characterController;
    public float speed = 5f;
    public float rotationspeed = 75f;
    // Start is called before the first frame update
    private Vector3 Rotation;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Rotation = new Vector3(0, Input.GetAxis("Mouse X")*rotationspeed*Time.deltaTime, 0);

        Vector3 move = new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime, -1,  Input.GetAxis("Vertical")*Time.deltaTime);
    

        move = this.transform.TransformDirection(move);
        characterController.Move(move*speed); 
        this.transform.Rotate(this.Rotation);


    }
}
