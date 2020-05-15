using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{

    public float movespeed = 10f;
    public bool isGrounded = false;
    int db = 0;
    public GameObject playerhead;
    public bool left;
    public bool right;
    

    void Update()
    {
        if (playerhead.GetComponent<onHead>().Head == false)
        {
            jump();
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * movespeed;
        }
        if(playerhead.GetComponent<onHead>().Head == true)
        {
            Vector3 no_movement = new Vector3(0f, 0f, 0f);
        }
      
        //To flip the character

        Vector3 characterScale = transform.localScale;

        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = -10;
            right = true;
            left = false;

        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = 10;
            left = true;
            right = false;
        }
        transform.localScale = characterScale;


        DoubleJump();
    }



    //Jump if added
    void jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
            db = 0 + 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
            db = 0 + 1;
        }
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
            db = 0 + 1;
        }

    }

    void DoubleJump()
    {
        //double jump
        if (isGrounded == false && db > 0)
        {
            if (Input.GetButtonDown("Jump"))
            {

                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
                db = 0 - 1;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
                db = 0 - 1;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);
                db = 0 - 1;
            }
        }
    }

    void singleJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6f), ForceMode2D.Impulse);

        }
    }


        //wall jump

      private void OnTriggerEnter2D(Collider2D collision)
      {
            if (collision.CompareTag("Wall"))
            {
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, .7f), ForceMode2D.Impulse);
               gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-.2f, .0f), ForceMode2D.Impulse);
            }
      }

    
}