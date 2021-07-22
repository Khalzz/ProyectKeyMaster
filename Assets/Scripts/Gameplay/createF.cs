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
            if (i - 130 == Controllers.fixedTimer)
            {
                Instantiate(fPrefab, transform.position, Quaternion.identity);
                Debug.Log("se ha creado un prefab");
            }
        }
    }
}
