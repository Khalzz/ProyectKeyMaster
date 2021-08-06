using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LevelSongs : MonoBehaviour
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
    } 

    public notes songNotes; // calling class

    public string jsonPath;
    public string jsonString;  // this have the json as a string ex: {"name":"rodrigo", "age":18}

    public string actualLevel;

    // actual level
    static public List<int> aNotes = new List<int>();
    static public List<int> sNotes = new List<int>();
    static public List<int> dNotes = new List<int>();
    static public List<int> fNotes = new List<int>();
    static public List<int> spaceNotes = new List<int>();
    static public List<int> jNotes = new List<int>();
    static public List<int> kNotes = new List<int>();
    static public List<int> lNotes = new List<int>();
    static public List<int> nNotes = new List<int>();

    //long notes
    static public List<int> longSpaceNotes = new List<int>();
    static public List<int> longSpaceTimes = new List<int>();

    /*
    static public List<int> lSLSwanLake = new List<int>() {519}; // note
    static public List<int> lSTSwanLake = new List<int>() {133}; // time
    */

    void Awake()
    {
        jsonPath = Application.streamingAssetsPath + "/" + MainMenu.levelName + "/notes.json"; // we asign the path of the json file bassed on the streamingAsset folder
        jsonString = File.ReadAllText(jsonPath); // read json text as just a text
        songNotes = JsonUtility.FromJson<notes>(jsonString); // transform the json text to a json
    }

    void Start()
    {   
        
    }

    void Update()
    {
        aNotes = songNotes.A;
        sNotes = songNotes.S;
        dNotes = songNotes.D;
        fNotes = songNotes.F;
        spaceNotes = songNotes.Space;
        jNotes = songNotes.J;
        kNotes = songNotes.K;
        lNotes = songNotes.L;
        nNotes = songNotes.N;

        // longSpaceNotes = lSLSwanLake;
        // longSpaceTimes = lSTSwanLake;
    }
}
