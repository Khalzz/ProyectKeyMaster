using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongLoader : MonoBehaviour
{
    public string songName;

    public AudioSource audioSource;
    public AudioClip audioClip;
    public string audioPath;

    void Awake()
    {
        if (MainMenu.levelName != "SyncTest")
        {
            audioSource = gameObject.AddComponent<AudioSource>(); // we add a audio source to our object in the game
            audioPath = Application.streamingAssetsPath + "/Songs" + "/" + MainMenu.levelName + "/";
            StartCoroutine(LoadAudio());
        }
    }

    void Start()
    {
       
    }

    private IEnumerator LoadAudio()
    {
        WWW request = GetAudioFromFile(audioPath, "audio.mp3");
        yield return request;

        audioClip = request.GetAudioClip();
        audioClip.name = MainMenu.levelName;

        PlayAudio();
    }

    private void PlayAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    private WWW GetAudioFromFile(string path, string filename)
    {
        string audioToLoad = string.Format(path + "{0}", filename);
        WWW request = new WWW(audioToLoad);
        return request;
    }
}
