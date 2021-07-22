using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jNote : MonoBehaviour
{
    public bool jState;
    static public bool jFire;
    static public bool pointState;

    void Start()
    {
        pointState = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0,-10f * Time.deltaTime,0);
        if(Input.GetButtonDown("J") && jState )
        {
            pointState = true;
            this.gameObject.SetActive(false);
        }
    }
    
    void OnTriggerStay2D(Collider2D other) 
    {
        jState = true;
        jFire = true;

    }
    void OnTriggerExit2D(Collider2D other)
    {
        jFire = false;
        jState = false;
    }
}
