using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class lNote : MonoBehaviour
{
    public bool lState;
    static public bool lFire;
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

        gameObject.transform.Translate(0,Controllers.generalNoteVelocity * Time.deltaTime,0);
        if(Input.GetButtonDown("L") && lState )
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
            lState = true;
            lFire = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "GameController")
        {
            lState = false;
            lFire = false;
        }
    }
}
