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
            if (i - 135 == Controllers.fixedTimer)
            {
                Instantiate(fPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
