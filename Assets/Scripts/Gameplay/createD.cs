using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createD : MonoBehaviour
{
    public GameObject dPrefab;

    void Start()
    {
        Instantiate(dPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
    }
}
