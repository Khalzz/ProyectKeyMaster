using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    string levelName;
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
        SceneManager.LoadScene(levelName);
    }
}