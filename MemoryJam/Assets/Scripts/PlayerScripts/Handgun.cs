using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun : MonoBehaviour
{
    public GameObject gun;
    public GameObject player;
    public GameObject right;
    public GameObject left;
    public GameObject melee;
    public Transform spawn;
    public bool Armed;

    private void Start()
    {
        gun.GetComponent<SpriteRenderer>().enabled = false;
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            gun.GetComponent<SpriteRenderer>().enabled = true;
            Armed = true;
            melee.GetComponent<SpriteRenderer>().enabled = false;

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            gun.GetComponent<SpriteRenderer>().enabled = false;
            Armed = false;
           

        }

        bulletshoot();
    }

    void bulletshoot()
    {
        if (Armed == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("hi");
                if(player.GetComponent<walk>().right == true)
                {
                    Instantiate(right, spawn.position, spawn.rotation);
                }
                if (player.GetComponent<walk>().left == true)
                {
                    Instantiate(left, spawn.position, spawn.rotation);
                }


            }
        }
        
    }
}
