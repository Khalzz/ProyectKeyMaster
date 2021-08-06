using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonText : MonoBehaviour
{
    /*
        here is a bug that dont let me "change" the name of the buttons when they are setted into the canvas (probabbly for the static values)
    */
    public string listButtonName;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponentInChildren<TextMeshProUGUI>().SetText(CreateSongButton.listButtonName);
        //var position = this.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, CreateSongButton.yPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {  
        
    }
}
