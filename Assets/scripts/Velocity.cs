using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Velocity : MonoBehaviour
{
    int sprint = 1;
    float speedMove = 4;
    float xMove;
    float zMove;
    CharacterController controller;
    Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

     void Update()
    {
        Move();
    }
    void Move()
    {
       
        xMove = Input.GetAxis("Horizontal");
        zMove = Input.GetAxis("Vertical");
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift)) sprint = 3; else sprint = 1;
            velocity = new Vector3(xMove, 0f, zMove);
            velocity = transform.TransformDirection(velocity);
            if (Input.GetKey(KeyCode.Space)) velocity.y += 1.2f; 
        }
        velocity.y -= 0.2f;
        controller.Move(velocity * speedMove * sprint * Time.deltaTime);
    }
}
