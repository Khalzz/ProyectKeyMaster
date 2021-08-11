using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.IO;

public class createLongSpace : MonoBehaviour
{
    public GameObject spacePrefab;
    public int basicIndex = 0;

    public double longNotesTimer;
    static public int fixedLongNotesTimer;

    void Update()
    {
        foreach(int i in LevelSongs.longSpaceNotes)
        {
            if ((i - 135 == Controllers.fixedTimer))
            {
                longNotesTimer = 0;
                longNotesTimer +=(1 * Time.deltaTime) * 100;
                fixedLongNotesTimer = Convert.ToInt32(longNotesTimer);           
            }
            if ( Controllers.fixedTimer >= i - 135 && Controllers.fixedTimer <= i - 135 + LevelSongs.longSpaceTimes[LevelSongs.longSpaceNotes.IndexOf(i)])
            {
                Debug.Log("instanciao");
                Instantiate(spacePrefab, transform.position, Quaternion.identity);
            }
        }
    }
}



