using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    static public bool itsPaused;

    public AudioSource audio;

    public GameObject pauseMenu;
    
    static public bool countStarted;

    // Start is called before the first frame update
    void Start()
    {
        AudioListener.pause = false;
        itsPaused = false;
        countStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause") && !itsPaused)
        {
            print("its paused");
            Pause();
        }
        else if (Input.GetButtonDown("Pause") && itsPaused)
        {
            print("its resumed");
            Resume();
        }
    }

    public void Pause()
    {
        AudioListener.pause = true;
        itsPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        itsPaused = false;
        Time.timeScale = 1f;
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
    }

    public void Restart()
    {
        itsPaused = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Play");
    }

    public void BackToMenu()
    {
        itsPaused = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
