using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class jNote : MonoBehaviour
{
    public bool jState;
    static public bool jFire;
    static public bool pointState;

    static public bool pointFailed;
    public double timer;
    public int fixedTimer;

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
        
        gameObject.transform.Translate(0,Controllers.generalNoteVelocity * Time.deltaTime,0);
        if(Input.GetButtonDown("J") && jState )
        {
            pointState = true;
            this.gameObject.SetActive(false);
        }
        if (fixedTimer == 160 && !pointFailed && MainMenu.levelName != "EmptySong") 
        {
            PointBar.points--;
            PointsCount.pointsStreak = 0;
            pointFailed = true;
        }
    }
    
    void OnTriggerStay2D(Collider2D other) 
    {
        if (other.tag == "GameController")
        {
            jState = true;
            jFire = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "GameController")
        {
            jState = false;
            jFire = false;
        }
    }
}
