using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createA : MonoBehaviour
{
    public GameObject aPrefab;

    void Update()
    {
        foreach(int i in LevelSongs.aNotes)
        {
            if (i - 125 == Controllers.fixedTimer)
            {
                Instantiate(aPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
