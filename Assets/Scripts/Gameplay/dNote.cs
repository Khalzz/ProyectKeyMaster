using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dNote : MonoBehaviour
{
    public bool dState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("D") && dState )
        {
            this.gameObject.SetActive(false);
        }
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        dState = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        dState = false;
    }
}
