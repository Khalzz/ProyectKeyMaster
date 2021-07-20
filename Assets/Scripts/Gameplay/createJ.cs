using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createJ : MonoBehaviour
{
    public GameObject jPrefab;

    void Start()
    {
        Instantiate(jPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
    }
}
