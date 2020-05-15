using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class right : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20;


    // Start is called before the first frame update
    void Start()
    {
       
        rb.velocity = transform.right * speed;
       
       

    }

}
