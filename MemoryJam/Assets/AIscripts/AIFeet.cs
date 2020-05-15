using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFeet : MonoBehaviour
{
    public bool onGround;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground"){
            onGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Ground"){
            onGround = false;
        }
    }
}
