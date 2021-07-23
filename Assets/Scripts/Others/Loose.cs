using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Loose : MonoBehaviour
{
    public static int hitCount;
    public bool state;
    public static bool looseState;

    void Update()
    {
        hitCount = 0;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Prefab") 
        {
            hitCount += 1;
        }
    }

    void MinusOne()
    {
        looseState = false;
        PointBar.points -= 1;
    }

}
