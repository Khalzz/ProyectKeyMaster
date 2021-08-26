using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class CreateSongButton : MonoBehaviour
{
    public static float yPosition;
    public static string levelName;

    public GameObject songButtonPrefab;
    public GameObject songContainer;

    public string[] directories; // string array
    List<string> fileNames = new List<string>();

    void Awake()
    {
        yPosition = 0;
        directories = Directory.GetDirectories(Application.streamingAssetsPath + "/Songs" + "/");
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
