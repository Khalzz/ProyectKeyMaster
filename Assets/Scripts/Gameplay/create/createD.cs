using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createD : MonoBehaviour
{
    public GameObject dPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.dNotes)
        {
            if (i - 135 == Controllers.fixedTimer)
            {
                Instantiate(dPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
