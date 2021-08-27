using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PointsCount : MonoBehaviour
{
    static public int points;
    static public int pointsStreak;

    public TextMeshPro pts;
    public TextMeshPro ptsStreak;

    public GameObject uiPoints;
    public GameObject uiStreakPoints;
    public TextMeshProUGUI uiTextPoints;

    // Start is called before the first frame update
    void Start()
    {
        pts = uiPoints.GetComponent<TextMeshPro>();
        ptsStreak = uiStreakPoints.GetComponent<TextMeshPro>();

        points = 0;
        pointsStreak = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pts.text = points.ToString();
        ptsStreak.text = pointsStreak.ToString();
    }
}
