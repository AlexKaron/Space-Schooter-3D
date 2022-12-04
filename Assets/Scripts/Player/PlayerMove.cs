using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] CharacterController charController;
    [SerializeField] float walkSpeed = 10f;
    [SerializeField] float jumpForce = 3f;
    [SerializeField] float gravity = -9.81f;
    [SerializeField]  Transform groundCheck;
    [SerializeField] float groundDistance = 0.4f;
    [SerializeField] LayerMask groundMask;
   
    Vector3 velocity;
    bool isGrounded;

   
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * x + transform.forward * z;
        charController.Move(move * walkSpeed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        charController.Move(velocity * Time.deltaTime);
    }

}
