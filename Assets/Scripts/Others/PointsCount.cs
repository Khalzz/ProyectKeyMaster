using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PointsCount : MonoBehaviour
{
    static public int points;

    public TextMeshPro pts;
    public GameObject uiPoints;
    public TextMeshProUGUI uiTextPoints;

    // Start is called before the first frame update
    void Start()
    {
        pts = uiPoints.GetComponent<TextMeshPro>();
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pts.text = points.ToString();
    }
}
