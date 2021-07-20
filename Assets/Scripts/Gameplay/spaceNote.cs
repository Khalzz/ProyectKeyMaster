using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceNote : MonoBehaviour
{
    public bool spaceState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Space") && spaceState )
        {
            this.gameObject.SetActive(false);
        }
    }
    void OnTriggerStay2D(Collider2D other) 
    {
        spaceState = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        spaceState = false;
    }
}
