using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    CharacterController controller;

    Vector3 forward;
    Vector3 strafe;
    Vector3 vertical;

    float forwardSpeed = 3f;
    float strafeSpeed = 3f;
    float run = 6f;

    float gravity;
    float jumpSpeed;
    float maxJumpHeight = 2f;
    float timeToMaxHeight = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<CharacterController>();

        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);

    }

    // Update is called once per frame
    void Update()
    {

        float forwardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        vertical += gravity * Time.deltaTime * Vector3.up;

        if(controller.isGrounded)
        {
            vertical = Vector3.down;
        }

        if(Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            vertical = jumpSpeed * Vector3.up;
        }

        if(Input.GetKey(KeyCode.F))
        {
            transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (35, 35, 35), Time.deltaTime);
        } 
		
		if(Input.GetKey(KeyCode.G))
		{
			transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (1, 1, 1), Time.deltaTime);
		}

        if(Input.GetKeyDown(KeyCode.Z)){
            forwardSpeed = run;
        }
        
        Vector3 finalVelocity = forward + strafe + vertical;

        controller.Move(finalVelocity * Time.deltaTime);
    }
}
