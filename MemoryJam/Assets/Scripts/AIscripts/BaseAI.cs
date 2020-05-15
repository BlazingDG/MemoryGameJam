using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAI : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpPower = 500f;
    public float jumpCooldown = 2f;
    public float attackRange = 2f;
    public float activationRange = 10f;
    public AIFeet feet;
    private Transform playerPosition;
    private float jumpTimer;
    private string state;

    void Start(){
        //find player and set starting state
        playerPosition = GameObject.FindWithTag("Player").transform;
        state = "Passive";
    }

    void Update(){
        //get distance to player
        float dist = Vector3.Distance(playerPosition.position, transform.position);
        //different sort of behaviour as states
        switch(state){
            case "Attacking":        
                if (dist > attackRange){
                    Chase();
                }
                break;
            case "Passive":
                if (dist < activationRange){state = "Attacking";}
                break;
        }
        //count jump timer down
        if(jumpTimer > 0f){jumpTimer -= Time.deltaTime*1f;}
    }

    //behaviour when chasing player character
    private void Chase(){
        //see if player is left or right of AI and move based on that
        if(playerPosition.position.x < transform.position.x){
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * moveSpeed);
        }else{
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * moveSpeed);
        }
        //If player is higher than AI, jump
        if(playerPosition.position.y > transform.position.y+1f){
            Jump();
        }
    }

    //jumps and starts a cooldown for jumping
    private void Jump(){
        if (jumpTimer <= 0f && feet.onGround){
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * jumpPower);
            jumpTimer = jumpCooldown;
        }
    }
}
