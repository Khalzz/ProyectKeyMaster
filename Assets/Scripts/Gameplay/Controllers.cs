// reparar sistema de ingreso de tiempo para notas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Controllers : MonoBehaviour
{
    // notes
    List<int> dNotes = new List<int>();
    public string dN;

    List<int> fNotes = new List<int>();
    public string fN;
    
    List<int> spaceNotes = new List<int>();
    public string spaceN;

    List<int> jNotes = new List<int>();
    public string jN;

    List<int> kNotes = new List<int>();
    public string kN;
    //notes

    public GameObject D,Dpressed, F,Fpressed, Space, SpacePressed, J, Jpressed, K, Kpressed;
    public GameObject dFire, fFire, spaceFire, jFire, kFire;

    // in game timer
    public double timer;
    static public int fixedTimer;

    // Start is called before the first frame update
    void Start()
    { 
        spaceN = "Space: ";
        dN = "D: ";
        fN = "F: ";
        jN = "J: ";
        kN = "K: ";

        timer = 0;       
    }

    // Update is called once per frame
    void Update()
    {
        timer +=(1 * Time.deltaTime) * 100;
        fixedTimer = Convert.ToInt32(timer);

        if (Input.GetButtonDown("D"))
        {
            D.SetActive(false);
            Dpressed.SetActive(true);
            dFire.SetActive(false);
            Debug.Log(fixedTimer);
            if (dNote.dFire == true)
            {
                D.SetActive(false);
                Dpressed.SetActive(false);
                dFire.SetActive(true);
            } 
            dNotes.Add(fixedTimer);
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
            Debug.Log(fixedTimer);
            fNotes.Add(fixedTimer);
            if (fNote.fFire == true)
            {
                F.SetActive(false);
                Fpressed.SetActive(false);
                fFire.SetActive(true);
            } 
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
            Debug.Log(fixedTimer);
            spaceNotes.Add(fixedTimer);
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

        if (Input.GetButtonDown("J"))
        {
            J.SetActive(false);
            Jpressed.SetActive(true);
            jFire.SetActive(false);
            Debug.Log(fixedTimer);
            jNotes.Add(fixedTimer);
            if (jNote.jFire == true)
            {
                J.SetActive(false);
                Jpressed.SetActive(false);
                jFire.SetActive(true);
            } 
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
            Debug.Log(fixedTimer);
            kNotes.Add(fixedTimer);
            if (kNote.kFire == true)
            {
                K.SetActive(false);
                Kpressed.SetActive(false);
                kFire.SetActive(true);
            } 
        }
        else if (Input.GetButtonUp("K"))
        {
            K.SetActive(true);
            Kpressed.SetActive(false);
            kFire.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            using (StreamWriter notes = File.AppendText("Notes.txt")) 
            {
                foreach (float i in spaceNotes)
                {
                    spaceN += (i.ToString() + ", ");
                }
                foreach (float i in dNotes)
                {
                    dN += (i.ToString() + ", ");
                }
                foreach (float i in fNotes)
                {
                    fN += (i.ToString() + ", ");
                }
                foreach (float i in jNotes)
                {
                    jN += (i.ToString() + ", ");
                }
                foreach (float i in kNotes)
                {
                    kN += (i.ToString() + ", ");
                }
                notes.WriteLine(spaceN + "\r" + dN + "\r" + fN + "\r" + jN + "\r" + kN);
                notes.Flush();
            }
        }
    }
}
