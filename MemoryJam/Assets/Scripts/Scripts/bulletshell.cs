using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletshell : MonoBehaviour
{
    float shell = 2f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0f, 5f);   
    }

   
}
