using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreateText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StreamWriter File = new StreamWriter("prueba.txt");
        File.Write("dato 1");
        File.Close();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
