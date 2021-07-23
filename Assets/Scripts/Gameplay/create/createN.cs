using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createN : MonoBehaviour
{
    public GameObject nPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.nNotes)
        {
            if (i - 130 == Controllers.fixedTimer)
            {
                Instantiate(nPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
