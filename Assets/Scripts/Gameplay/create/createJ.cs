using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createJ : MonoBehaviour
{
    public GameObject jPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.jNotes)
        {
            if (i - 125 == Controllers.fixedTimer)
            {
                Instantiate(jPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
