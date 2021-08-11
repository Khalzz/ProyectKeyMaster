using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createL : MonoBehaviour
{
    public GameObject lPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.lNotes)
        {
            if (i - 135 == Controllers.fixedTimer)
            {
                Instantiate(lPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
