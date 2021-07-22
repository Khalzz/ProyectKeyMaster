using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dNote : MonoBehaviour
{
    public bool dState;
    static public bool dFire;
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
        if(Input.GetButtonDown("D") && dState )
        {
            pointState = true;
            this.gameObject.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        dFire = true;
        dState = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        dFire = false;
        dState = false;
    }
}
