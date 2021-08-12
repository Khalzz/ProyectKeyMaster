using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    static public string levelName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // quit
    public void quit()
    {
        Application.Quit();
        Debug.Log("GET OUUUUUUUUUT!!!");
    }

/*    public void test()
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
*/

    public void SyncTest()
    {
        SceneManager.LoadScene("SyncTest");
        levelName = "SyncTest";
    }
}
