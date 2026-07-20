using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public float PlayerSpeed;
    public float JumpHeight;
    public Rigidbody2D rb;
    private bool IsGrounded;
    private float x;

    PlayerControls controls;
    float direction=0;
    float jump = 0;

    // Update is called once per frame
    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.player.move.performed += ctx => {
            direction = ctx.ReadValue<float>();
        };
        controls.player.jump.performed += ctx => {
            jump = ctx.ReadValue<float>();
        };
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");

        if (jump>0 && IsGrounded)
        {
            Jump();
        }
        if (jump<0 && !IsGrounded)
        {
            Down();
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(direction * PlayerSpeed, rb.linearVelocity.y);
    }

    public void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpHeight);
    }
    public void Down()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, -JumpHeight);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
        }
    }

}
