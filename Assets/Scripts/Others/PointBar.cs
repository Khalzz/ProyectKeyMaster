using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PointBar : MonoBehaviour
{
    public GameObject point0;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;
    public GameObject point8;
    public GameObject point9;
    public GameObject point10;

    

    static public int points;
    
    void Start()
    {
        points = 5;
    }

    void Update()
    {
        if (spaceNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            spaceNote.pointState = false;
            Debug.Log(points);
        }
        if (aNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            aNote.pointState = false;
            Debug.Log(points);
        }
        if (sNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            sNote.pointState = false;
            Debug.Log(points);
        }
        if (lNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            lNote.pointState = false;
            Debug.Log(points);
        }
        if (nNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            nNote.pointState = false;
            Debug.Log(points);
        }
        if (kNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            kNote.pointState = false;
            Debug.Log(points);
        }
        if (jNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            jNote.pointState = false;
            Debug.Log(points);
        }
        if (fNote.pointState == true)
        {
            PointsCount.points++;
            points++;
            fNote.pointState = false;
            Debug.Log(points);
        }
        if (dNote.pointState == true)
        {
            PointsCount.points++; 
            points++;
            dNote.pointState = false;
            Debug.Log(points);
        }

        if (points == 0)
        {
            point0.SetActive(true);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 1)
        {
            point0.SetActive(false);
            point1.SetActive(true);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 2)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(true);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 3)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(true);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 4)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(true);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 5)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(true);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 6)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(true);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 7)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(true);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 8)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(true);
            point9.SetActive(false);
            point10.SetActive(false);
        }
        else if (points == 9)
        {
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(true);
            point10.SetActive(false);
        }
        else if (points >= 10)
        {
            points = 10;
            point0.SetActive(false);
            point1.SetActive(false);
            point2.SetActive(false);
            point3.SetActive(false);
            point4.SetActive(false);
            point5.SetActive(false);
            point6.SetActive(false);
            point7.SetActive(false);
            point8.SetActive(false);
            point9.SetActive(false);
            point10.SetActive(true);
        }
    }
}
