using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour {

    private Transform lookAt;
    private Vector3 startOfset;
    private Vector3 moveVector;
    private float transition = 0.0f;
    private float animationDuration = 2.0f;
    private Vector3 animationOffset = new Vector3(0, 5, -15);
	// Use this for initialization
	void Start () {
        lookAt=GameObject.FindGameObjectWithTag("Player").transform;
        startOfset = transform.position - lookAt.position;
	}
	
	// Update is called once per frame
	void Update () {
        moveVector= lookAt.position + startOfset;

        // X
        moveVector.x = 0;

        // Y

      //  moveVector.y = Mathf.Clamp(moveVector.y, 3, 5);
        transform.position = moveVector;
        //if (transition > 1.0f)
        //{
        //    transform.position = moveVector;
        //}
        //else
        //{
        //    // Animation start
        //     transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
         
        //    transition += Time.deltaTime * 1 / animationDuration;
        //    transform.LookAt(lookAt.position + Vector3.up);
        //}
    
	}
}
