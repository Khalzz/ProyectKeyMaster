using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class kNote : MonoBehaviour
{
    public bool kState;
    static public bool kFire;
    static public bool pointState;

    static public bool pointFailed;
    public double timer;
    public int fixedTimer;
    // Start is called before the first frame update
    void Start()
    {
        pointState = false;
        timer = 0f;
        pointFailed = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer +=(1 * Time.deltaTime) * 100;
        fixedTimer = Convert.ToInt32(timer);
        
        gameObject.transform.Translate(0,-10f * Time.deltaTime,0);
        if(Input.GetButtonDown("K") && kState )
        {
            pointState = true;
            this.gameObject.SetActive(false);
        }
        if (fixedTimer == 160 && !pointFailed) 
        {
            PointBar.points--;
            pointFailed = true;
        }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        kState = true;
        kFire = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        kFire = false;
        kState = false;
    }
}