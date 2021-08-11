using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class CreateSongButton : MonoBehaviour
{
    public static float yPosition = 0;
    public static string levelName;

    public GameObject songButtonPrefab;

    public string[] directories; // string array
    List<string> fileNames = new List<string>();

    void Awake()
    {
        directories = Directory.GetDirectories(Application.streamingAssetsPath);
        foreach (string i in directories)
        {
            levelName = Path.GetFileName(i);
            Instantiate(songButtonPrefab, transform.position, Quaternion.identity, transform.parent); // the "transform.parent" makes that this prefab is instantiated with this as his parent
            ButtonPrefab.levelToOpen = i.Substring(63);
            yPosition -= 26;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
              
    }
}
