using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sync : MonoBehaviour
{
    public GameObject Space, SpacePressed, spaceFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Space"))
        {
            Space.SetActive(false);
            SpacePressed.SetActive(true);
            spaceFire.SetActive(false);
            if (spaceNote.spaceFire == true)
            {
                Space.SetActive(false);
                SpacePressed.SetActive(false);
                spaceFire.SetActive(true);
            } 
        }
        else if (Input.GetButtonUp("Space"))
        {
            Space.SetActive(true);
            SpacePressed.SetActive(false);
            spaceFire.SetActive(false);
        }
    }
}
