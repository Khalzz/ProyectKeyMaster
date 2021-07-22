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
            if (i - 130 == Controllers.fixedTimer)
            {
                Instantiate(dPrefab, transform.position, Quaternion.identity);
                Debug.Log("se ha creado un prefab");
            }
        }
    }
}
