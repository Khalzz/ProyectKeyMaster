// reparar sistema de ingreso de tiempo para notas

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;

public class Controllers : MonoBehaviour
{
    List<float> spaceNotes = new List<float>();

    public GameObject D,Dpressed, F,Fpressed, Space, SpacePressed, J, Jpressed, K, Kpressed;
    public GameObject dFire, fFire, spaceFire, jFire, kFire;

    // in game timer
    public float timer;

    // Start is called before the first frame update
    void Start()
    { 
        timer = 0;       
    }

    // Update is called once per frame
    void Update()
    {
        timer += (1 * Time.deltaTime) * 10;

        if (Input.GetButtonDown("D"))
        {
            D.SetActive(false);
            Dpressed.SetActive(true);
            dFire.SetActive(false);
            Debug.Log(timer);
        }
        else if (Input.GetButtonUp("D"))
        {
            D.SetActive(true);
            Dpressed.SetActive(false);
            dFire.SetActive(false);
        }

        if (Input.GetButtonDown("F"))
        {
            F.SetActive(false);
            Fpressed.SetActive(true);
            fFire.SetActive(false);
            Debug.Log(timer);
        }
        else if (Input.GetButtonUp("F"))
        {
            F.SetActive(true);
            Fpressed.SetActive(false);
            fFire.SetActive(false);
        }

        if (Input.GetButtonDown("Space"))
        {
            Space.SetActive(false);
            SpacePressed.SetActive(true);
            spaceFire.SetActive(false);
            Debug.Log(timer);

            spaceNotes.Add(timer);
            Debug.Log(spaceNotes);
            
        }
        else if (Input.GetButtonUp("Space"))
        {
            Space.SetActive(true);
            SpacePressed.SetActive(false);
            spaceFire.SetActive(false);
        }

        if (Input.GetButtonDown("J"))
        {
            J.SetActive(false);
            Jpressed.SetActive(true);
            jFire.SetActive(false);
            Debug.Log(timer);
        }
        else if (Input.GetButtonUp("J"))
        {
            J.SetActive(true);
            Jpressed.SetActive(false);
            jFire.SetActive(false);
        }

        if (Input.GetButtonDown("K"))
        {
            K.SetActive(false);
            Kpressed.SetActive(true);
            kFire.SetActive(false);
            Debug.Log(timer);
        }
        else if (Input.GetButtonUp("K"))
        {
            K.SetActive(true);
            Kpressed.SetActive(false);
            kFire.SetActive(false);
        }
    }
}
