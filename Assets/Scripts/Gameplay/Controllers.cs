// reparar sistema de ingreso de tiempo para notas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Controllers : MonoBehaviour
{
    public bool longNotesMode;

    // hard notes 1
    //a
    static public List<int> aNotes = new List<int>();
    public string aN;
    //a

    //s
    static public List<int> sNotes = new List<int>();
    public string sN;
    //s
    // hard notes 1

    // notes
    //d
    static public List<int> dNotes = new List<int>();
    public string dN;
    //d

    //f
    static public List<int> fNotes = new List<int>();
    public string fN;
    //f

    //space
    static public List<int> spaceNotes = new List<int>();
    public string spaceN;

    List<int> spaceKeepPressing = new List<int>(); // normal timer
    public string spaceKeepN;
    public bool spacePressed;

    List<int> spaceTimePressing = new List<int>(); // new timer
    public string spaceTimeN;
    //space

    //j
    static public List<int> jNotes = new List<int>();
    public string jN;
    //j

    //k
    static public List<int> kNotes = new List<int>();
    public string kN;
    //k
    //normal notes

    // hard notes 1
    //l
    static public List<int> lNotes = new List<int>();
    public string lN;
    //l

    //n
    static public List<int> nNotes = new List<int>();
    public string nN;
    //n
    // hard notes 1

    public GameObject D,Dpressed, F,Fpressed, Space, SpacePressed, J, Jpressed, K, Kpressed, A, Apressed, S, Spressed, L, Lpressed, N, Npressed, Sc, Scpressed, fullN, fullSc;
    public GameObject dFire, fFire, spaceFire, jFire, kFire, aFire, sFire, lFire, nFire, ScFire;

    // in game timer
    public double timer;
    static public int fixedTimer;

    public double longNotesTimer;
    static public int fixedLongNotesTimer;

    // Start is called before the first frame update
    void Start()
    {
        longNotesMode = false;
        timer = 0;       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Long"))
        {
            if (!longNotesMode)
            {
                Debug.Log("LNM activated");
                longNotesMode = true;
            }
            else if (longNotesMode)
            {
                Debug.Log("LNM deactivated");
                longNotesMode = false;
            }
        }
        
        timer +=(1 * Time.deltaTime) * 100;
        fixedTimer = Convert.ToInt32(timer);

        if (ChangeLayout.actualLayout == "spanish")
        {
            fullN.SetActive(true);
            fullSc.SetActive(false);
        }
        else if (ChangeLayout.actualLayout == "english")
        {
            fullN.SetActive(false);
            fullSc.SetActive(true);
        }


        if (Input.GetButtonDown("A"))
        {
            A.SetActive(false);
            Apressed.SetActive(true);
            aFire.SetActive(false);
            Debug.Log(fixedTimer);
            aNotes.Add(fixedTimer);
            if (aNote.aFire == true)
            {
                A.SetActive(false);
                Apressed.SetActive(false);
                aFire.SetActive(true);
            } 
        }
        else if (Input.GetButtonUp("A"))
        {
            A.SetActive(true);
            Apressed.SetActive(false);
            aFire.SetActive(false);
        }
        if (Input.GetButtonDown("S"))
        {
            S.SetActive(false);
            Spressed.SetActive(true);
            sFire.SetActive(false);
            Debug.Log(fixedTimer);
            sNotes.Add(fixedTimer);
            if (sNote.sFire == true)
            {
                S.SetActive(false);
                Spressed.SetActive(false);
                sFire.SetActive(true);
            }
        }
        else if (Input.GetButtonUp("S"))
        {
            S.SetActive(true);
            Spressed.SetActive(false);
            sFire.SetActive(false);
        }
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

        if (Input.GetButtonDown("Space") && !longNotesMode)
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
        else if (Input.GetButton("Space") && longNotesMode)
        {
            longNotesTimer +=(1 * Time.deltaTime) * 100;
            fixedLongNotesTimer = Convert.ToInt32(longNotesTimer);

            if (!spacePressed)
            {
                spacePressed = true;  
                spaceKeepPressing.Add(fixedTimer);
            } 
        }
        else if (Input.GetButtonUp("Space") && longNotesMode)
        {
            spacePressed = false;
            spaceTimePressing.Add(fixedLongNotesTimer);
            longNotesTimer = 0;

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
        if (Input.GetButtonDown("L"))
        {
            L.SetActive(false);
            Lpressed.SetActive(true);
            lFire.SetActive(false);
            Debug.Log(fixedTimer);
            lNotes.Add(fixedTimer);
            if (lNote.lFire == true)
            {
                L.SetActive(false);
                Lpressed.SetActive(false);
                lFire.SetActive(true);
            }
        }
        else if (Input.GetButtonUp("L"))
        {
            L.SetActive(true);
            Lpressed.SetActive(false);
            lFire.SetActive(false);
        }
        if (Input.GetButtonDown("N"))
        {
            Sc.SetActive(false);
            Scpressed.SetActive(true);
            ScFire.SetActive(false);
            Debug.Log(fixedTimer);

            N.SetActive(false);
            Npressed.SetActive(true);
            nFire.SetActive(false);
            Debug.Log(fixedTimer);

            nNotes.Add(fixedTimer);
            if (nNote.nFire == true)
            {
                N.SetActive(false);
                Npressed.SetActive(false);
                nFire.SetActive(true);
            }
        }
        else if (Input.GetButtonUp("N"))
        {
            Sc.SetActive(true);
            Scpressed.SetActive(false);
            ScFire.SetActive(false);

            N.SetActive(true);
            Npressed.SetActive(false);
            nFire.SetActive(false);
        }
    }
}
