using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFall : MonoBehaviour
{

    public float PlayerSpeed = 5f;
    public float fallSpeed =0.1f;
    public float speedMultiplier = 1.001f;
    public float maxFallSpeed = 0.2f;
    public Rigidbody2D rb;
     

    private float x;

    PlayerControls controls;
    float direction=0;
    bool alive;
    

    // Update is called once per frame
    private void Awake()
    {
        alive = true;
        controls = new PlayerControls();
        controls.Enable();

        controls.player.move.performed += ctx => {
            direction = ctx.ReadValue<float>();
        };
        
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");

        
    }

    void FixedUpdate()
    {
        if (alive)
        {
            rb.linearVelocity = new Vector2(direction * PlayerSpeed, 0);
            if(fallSpeed<maxFallSpeed){
                fallSpeed = fallSpeed*speedMultiplier;
                }
            rb.position = new Vector2(rb.position.x, rb.position.y - (fallSpeed));
        }
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            alive = false;
            rb.linearVelocity = new Vector2(0, 0);
        }
    }







}
