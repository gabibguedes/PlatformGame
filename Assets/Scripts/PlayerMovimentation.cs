using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentation : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float runSpeed = 5;
    public float jumpSpeed = 5;
    public int maxJumps = 2;

    private bool onMovingFloor = false;

    private int currentJump = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(x * runSpeed, rigidBody.velocity.y);

        if(Input.GetButtonDown("Jump") && currentJump < maxJumps){
            currentJump += 1;
            rigidBody.velocity += Vector2.up * jumpSpeed;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.contacts[0].normal == Vector2.up){
            currentJump = 0;
        }  
    }
    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("MovingPlatform")){
            transform.parent = other.transform;
            onMovingFloor = true;
        }
    }
    void OnCollisionExit2D()
    {
        if(onMovingFloor){
            transform.parent = null;
            onMovingFloor = false;
        }
    }
}
