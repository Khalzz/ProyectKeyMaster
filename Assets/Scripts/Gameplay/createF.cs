using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createF : MonoBehaviour
{
    public GameObject fPrefab;

    void Start()
    {
        Instantiate(fPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
    }
}
