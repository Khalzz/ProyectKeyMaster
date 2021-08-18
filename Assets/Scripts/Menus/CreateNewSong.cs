/*
this is my first time working with json files so im gonna make comments like a crazy idiot
if you are watching this code and you think that you should do that, you're wrong and i hate you
this is just for learning so uh oh stinky poop hahaha poopy funny poopy alalalala funny poop poop funny uwoooooooooo...
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class CreateNewSong : MonoBehaviour
{

    [System.Serializable]
    public class notes 
    {
        public List<int> A = new List<int>();
        public List<int> S = new List<int>();
        public List<int> D = new List<int>();
        public List<int> F = new List<int>();
        public List<int> Space = new List<int>();
        public List<int> J = new List<int>();
        public List<int> K = new List<int>();
        public List<int> L = new List<int>();
        public List<int> N = new List<int>();
        public int End;
    } 

    public string jsonPath;
    public string jsonString;  // this have the json as a string ex: {"name":"rodrigo", "age":18}

    public notes newSongNotes; // calling class

    void Awake()
    {
        jsonPath = Application.streamingAssetsPath + "/EmptySong/notes.json"; // we asign the path of the json file bassed on the streamingAsset folder

        if (!Directory.Exists(Application.streamingAssetsPath + "/EmptySong"))
        {
            Directory.CreateDirectory(Application.streamingAssetsPath + "/EmptySong");
            jsonString = JsonUtility.ToJson(newSongNotes);
            File.WriteAllText(jsonPath, jsonString);
            print("a new empty song folder have been created");
        }

        jsonString = File.ReadAllText(jsonPath); // read json text as just a text
        newSongNotes = JsonUtility.FromJson<notes>(jsonString); // transform the json text to a json
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (int i in Controllers.aNotes)
            {
                newSongNotes.A.Add(i);
            }
            foreach (int i in Controllers.sNotes)
            {
                newSongNotes.S.Add(i);
            }
            foreach (int i in Controllers.dNotes)
            {
                newSongNotes.D.Add(i);
            }
            foreach (int i in Controllers.fNotes)
            {
                newSongNotes.F.Add(i);
            }
            foreach (int i in Controllers.spaceNotes)
            {
                newSongNotes.Space.Add(i);
            }
            foreach (int i in Controllers.jNotes)
            {
                newSongNotes.J.Add(i);
            }
            foreach (int i in Controllers.kNotes)
            {
                newSongNotes.K.Add(i);
            }
            foreach (int i in Controllers.lNotes)
            {
                newSongNotes.L.Add(i);
            }
            foreach (int i in Controllers.nNotes)
            {
                newSongNotes.N.Add(i);
            }
            newSongNotes.End = Controllers.fixedTimer;
            jsonString = JsonUtility.ToJson(newSongNotes); // we get this string and transform it to a json again
            File.WriteAllText(jsonPath, jsonString); // we write the json string in the file
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            File.Move(Application.streamingAssetsPath + "/EmptySong", Application.streamingAssetsPath + "/LatestSong");
        }
    } 
}

 
