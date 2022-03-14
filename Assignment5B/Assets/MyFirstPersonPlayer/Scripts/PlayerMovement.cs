/*
 * Zach Daly
 * Assignment 5B
 * Controls player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   /// Variables for movement
    // Set controller ref in Inspector
    public CharacterController controller;
    public float speed = 12f;

    /// Variables for gravity
    public Vector3 velocity;
    public float gravity = -9.81f;
    public float gravityMultiplier = 2f;

    /// Variables for GroundCheck
    // Set Transform and LayerMask in inspector
    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDistance = 0.4f;
    public bool isGrounded;

    /// Variable for jump
    public float jumpHeight = 3f;

    private void Awake()
    {
        gravity *= gravityMultiplier;
    }

    void Update()
    {
        // Check if player is on the ground and reset y velocity if they are
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Move player
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // Jump Code
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
