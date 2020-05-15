
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject Player;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<walk>().isGrounded = true;
        }


    }

    private void OnCollisionExit2D(Collision2D collision)

    {

        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<walk>().isGrounded = false;
        }
    }
}

