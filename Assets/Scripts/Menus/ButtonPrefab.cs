using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class ButtonPrefab : MonoBehaviour
{
    public Button thisButton;
    public GameObject parent;

    public string thisLevel;

    static public string levelToOpen;

    void Awake()
    {
        thisLevel = CreateSongButton.levelName;
        this.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, CreateSongButton.yPosition);
        this.GetComponentInChildren<TextMeshProUGUI>().SetText(thisLevel);
    }

    void Start()
    {
        thisButton = this.GetComponent<Button>(); // a Button element needs to be linked to the Button Component, not to the object in fact
        thisButton.onClick.AddListener(OnClick); // we call a function with this
    }

    void Update()
    {
        
    }

    void OnClick()
    {
        MainMenu.levelName = thisLevel;
        SceneManager.LoadScene("Play");
        print(thisLevel);
    }
}
