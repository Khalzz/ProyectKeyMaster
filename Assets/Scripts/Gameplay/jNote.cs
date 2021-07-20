using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jNote : MonoBehaviour
{
    public bool jState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("J") && jState )
        {
            this.gameObject.SetActive(false);
        }
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        jState = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        jState = false;
    }
}
