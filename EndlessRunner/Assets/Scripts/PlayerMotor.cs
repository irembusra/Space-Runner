using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {


    private CharacterController cc_Controller;
    private Vector3 moveVector;
    private float f_speed=5.0f;
    private float animationDuration = 0.5f;

    private float verticalVelocity = 0.0f;

    private float gravity = 12.0f;
	// Use this for initialization
	void Start () {
        cc_Controller = GetComponent<CharacterController>();
     
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time < animationDuration) // no moves when start animation
        {
            cc_Controller.Move(Vector3.forward * f_speed * Time.deltaTime);
            return;
        }
        moveVector = Vector3.zero;

        if(cc_Controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        // Left and right
        moveVector.x = Input.GetAxisRaw("Horizontal") * f_speed;
   
        // Up and down
        moveVector.y = verticalVelocity;

        // Forward
        moveVector.z = f_speed;
        cc_Controller.Move(moveVector * Time.deltaTime);

    }
}
