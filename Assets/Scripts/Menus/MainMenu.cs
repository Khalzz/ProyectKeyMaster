using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    static public string levelName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Level charger

    // quit
    public void quit()
    {
        Application.Quit();
        Debug.Log("GET OUUUUUUUUUT!!!");
    }

    public void test()
    {
        levelName = "Test";
        SceneManager.LoadScene("Play");
    }

    public void test2()
    {
        levelName = "Descent into cerberon";
        SceneManager.LoadScene("Play");
    }

    public void swanLake()
    {
        levelName = "Swan Lake";
        SceneManager.LoadScene("Play");
    }
}
