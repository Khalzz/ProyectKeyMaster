using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createF : MonoBehaviour
{
    public GameObject fPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.fNotes)
        {
            if (i - 125 == Controllers.fixedTimer)
            {
                Instantiate(fPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
