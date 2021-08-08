using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class CreateSongButton : MonoBehaviour
{
    /* public static   float yPosition = 0;
    public GameObject levelMenu;
    public GameObject songButtonPrefab;
    public TextMeshProUGUI buttonText;
    */

    public string[] directories; // string array
    List<string> fileNames = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        directories = Directory.GetDirectories(Application.streamingAssetsPath);
        foreach (string i in directories)
        {
            Debug.Log(i.Substring(63));
        }
    }

    void Update()
    {
              
    }
}
