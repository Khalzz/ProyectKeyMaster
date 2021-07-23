using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createS : MonoBehaviour
{
    public GameObject sPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.sNotes)
        {
            if (i - 130 == Controllers.fixedTimer)
            {
                Instantiate(sPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
