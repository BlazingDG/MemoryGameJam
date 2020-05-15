using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryDistortControl : MonoBehaviour
{
    public GameObject Distort;
    public SpriteRenderer Darkness;
    private float counter;
    private bool counting;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(counting){
            counter += Time.deltaTime;
            if(counter > 0.2f && counter < 0.3f || counter > 0.5f && counter < 0.6f || counter > 0.7f){
                Distort.SetActive(true);
            }else{
                Distort.SetActive(false);
            }
            Darkness.color = new Color(0f, 0f, 0f, counter/2f);
        }
    }

    public void ActivateDistort(){
        counting = true;
    }
}
