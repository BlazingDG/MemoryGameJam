using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float velX = 5;
    float velY = 0;
    Rigidbody2D rb;
    public GameObject Gun;
    public GameObject player;
    public Quaternion z;
    public GameObject Bullet;
    public GameObject bulletspawn;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void bulletshoot()
    {
        if(Gun.GetComponent<Handgun>().gun.GetComponent<SpriteRenderer>().enabled == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(Bullet, bulletspawn.transform.position, Quaternion.identity);
                
            }
        }
    }
}
