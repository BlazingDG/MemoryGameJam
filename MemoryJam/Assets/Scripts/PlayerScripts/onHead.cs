using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHead : MonoBehaviour
{
    //to see if the player is on his head. 
    public bool Head;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Head = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Head = false;
        }
    }
}
