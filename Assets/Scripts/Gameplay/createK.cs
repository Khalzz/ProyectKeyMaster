using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createK : MonoBehaviour
{
    public GameObject kPrefab;

    void Start()
    {
        Instantiate(kPrefab, transform.position, Quaternion.identity);
    }

    void Update()
    {
    }
}
