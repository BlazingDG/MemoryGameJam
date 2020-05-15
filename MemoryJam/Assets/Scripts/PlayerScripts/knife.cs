using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public GameObject pistol;
    public Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GetComponent<SpriteRenderer>().enabled = true;
            pistol.GetComponent<SpriteRenderer>().enabled = false;
            pistol.GetComponent<Handgun>().Armed = false;

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("splash");
                Anim.Play("knife animation");
               
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
