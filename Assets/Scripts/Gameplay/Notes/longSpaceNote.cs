using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class longSpaceNote : MonoBehaviour
{
    public bool spaceState;
    static public bool spaceFire;
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

    void Update()
    {
        timer +=(1 * Time.deltaTime) * 100;
        fixedTimer = Convert.ToInt32(timer);

        gameObject.transform.Translate(0,Controllers.generalNoteVelocity * Time.deltaTime,0);
        if(Input.GetButton("Space") && spaceState)
        {
            pointState = true;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color( 0.5754f, 0.5754f, 0.5754f);
        }

        /* later aligator
        if (fixedTimer == 160 && !pointFailed) 
        {
            PointBar.points--;
            pointFailed = true;
        }
        */
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        if (other.tag == "GameController")
        {
            spaceState = true;
            spaceFire = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "GameController")
        {
            spaceState = false;
            spaceFire = false;
        }
    }
}
