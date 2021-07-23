using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayout : MonoBehaviour
{

    static public string actualLayout;
    public GameObject spanish;
    public GameObject english;

    // Start is called before the first frame update
    void Start()
    {
        actualLayout = "spanish";
    }

    public void Layout()
    {
        if (actualLayout == "spanish")
        {
            actualLayout = "english";
            spanish.SetActive(false);
            english.SetActive(true);
        }
        else if (actualLayout == "english")
        {
            actualLayout = "spanish";
            english.SetActive(false);
            spanish.SetActive(true);
        }
    }
}
