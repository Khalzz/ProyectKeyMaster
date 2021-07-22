using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class createSpace : MonoBehaviour
{
    public GameObject spacePrefab;

    void Update()
    {
        foreach(int i in LevelSongs.spaceNotes)
        {
            if (i - 130 == Controllers.fixedTimer)
            {
                Instantiate(spacePrefab, transform.position, Quaternion.identity);
                Debug.Log("se ha creado un prefab");
            }
        }
    }
}