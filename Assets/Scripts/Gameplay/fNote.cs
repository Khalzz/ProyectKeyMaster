using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fNote : MonoBehaviour
{
    public bool fState;
    static public bool fFire;
    static public bool pointState;
    // Start is called before the first frame update
    void Start()
    {
        pointState = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0,-10f * Time.deltaTime,0);
        if(Input.GetButtonDown("F") && fState )
        {
            pointState = true;
            this.gameObject.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        fFire = true;
        fState = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        fFire = false;
        fState = false;
    }
}
