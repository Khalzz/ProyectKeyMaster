using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createSpace : MonoBehaviour
{
    public GameObject spacePrefab;

    void Start()
    {
        Instantiate(spacePrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
    }
}