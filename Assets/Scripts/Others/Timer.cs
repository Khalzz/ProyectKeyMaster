using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    static public double timer;

    static public bool paused;

    public int fixedTimer;
    static public GameObject uiTimer;
    static public TextMeshProUGUI uiTextTimer;

    // Start is called before the first frame update
    void Start()
    {
        paused = true;
        uiTimer.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.countStarted)
        {
            paused = true;
            uiTimer.SetActive(true);
            timer -=(1 * Time.deltaTime);
            uiTextTimer.text = timer.ToString("F0");
        }
        if (timer.ToString("F0") == "0")
        {
            paused = false;
            PauseMenu.countStarted = false;
            Controllers.generalNoteVelocity = -10f;
            uiTimer.SetActive(false);

        }
    }
}
