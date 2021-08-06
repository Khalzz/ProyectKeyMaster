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

    public string[] directories;
    List<string> fileNames = new List<string>();

    public static string listButtonName;

    // Start is called before the first frame update
    void Start()
    {
        directories = Directory.GetDirectories("./Songs");
        
        foreach (string i in directories)
        {
            Debug.Log(i.Substring(8));
            yPosition -= 26;
            Instantiate(songButtonPrefab, transform.position, Quaternion.identity, transform.parent);
            Debug.Log(yPosition);
            Debug.Log(listButtonName);
            if (gameObject.tag == "Prefab")
            {
                this.GetComponentInChildren<TextMeshProUGUI>().SetText(listButtonName);
                this.GetComponent<RectTransform>().anchoredPosition = new Vector3(0,yPosition, 0);
            }
        }
    }

    void Update()
    {
              
    }
    */
}
