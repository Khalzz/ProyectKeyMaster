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

    public GameObject loseMenu;

    public GameObject winMenu;

    public bool canEsc;
    
    static public bool countStarted;

    void Awake()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        canEsc = true;
        itsPaused = false;
        countStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause") && !itsPaused && canEsc)
        {
            print("its paused");
            Pause();
        }
        else if (Input.GetButtonDown("Pause") && itsPaused && canEsc)
        {
            print("its resumed");
            Resume();
        }

        if (PointBar.points < 0)
        {
            Lose();
        }
        
        if (Controllers.fixedTimer == LevelSongs.endLevel)
        {
            Win();
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
        itsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Play");
    }

    public void BackToMenu()
    {
        itsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Lose()
    {
        canEsc = false;
        itsPaused = true;
        AudioListener.pause = true;
        loseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Win()
    {
        canEsc = false;
        itsPaused = true;
        AudioListener.pause = true;
        winMenu.SetActive(true);
        Time.timeScale = 0f;
    }

}
