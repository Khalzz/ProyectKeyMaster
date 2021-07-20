using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kNote : MonoBehaviour
{
    public bool kState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("K") && kState )
        {
            this.gameObject.SetActive(false);
        }
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        kState = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        kState = false;
    }
}
