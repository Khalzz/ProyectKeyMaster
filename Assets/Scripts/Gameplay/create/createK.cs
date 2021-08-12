using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createK : MonoBehaviour
{
    public GameObject kPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.kNotes)
        {
            if (i - 125 == Controllers.fixedTimer)
            {
                Instantiate(kPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
