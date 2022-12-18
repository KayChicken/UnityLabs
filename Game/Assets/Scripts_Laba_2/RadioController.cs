using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;


public class RadioController : MonoBehaviour
{
    AudioSource audioSource;
    public List<AudioClip> audioClips = new List<AudioClip>();

    public TextMeshProUGUI trackNameUI;
    public Slider trackSlider;
    public GameObject radioMenu;
    public GameObject isTrigger;

    public string path;
    public int trackIndex = 0;

    
    public float endTimeAudio;
    

    void Start()
        
    {
        
        audioSource = gameObject.GetComponent<AudioSource>();
        UpdateAudio();
    }


    private void Update()
    {

       

        if (trackSlider.value >= endTimeAudio - 0.02f)
        {
          
            NextTrack();
        }


    }

    private void FixedUpdate()
    {

        
        trackSlider.value = audioSource.time;
    }

    public void UpdateAudio()
    {
        trackSlider.value = 0;
        endTimeAudio = audioClips[trackIndex].length;
        trackSlider.maxValue = endTimeAudio;
        audioSource.clip = audioClips[trackIndex];
        trackNameUI.text = audioClips[trackIndex].name;
    }

    public void PlayAudio()
    {
        audioSource.Play();
    }

    public void PauseAudio()
    {
        audioSource.Pause();
    }


    public void StopAudio()
    {
        audioSource.Stop();
    }

    public void ChooseTrack()
    {

        path = EditorUtility.OpenFilePanel("Image", "", "mp3");
        var fileName = Path.GetFileName(path);
        StartCoroutine(GetSound(fileName));






    }



    public void NextTrack()
    {
        if (trackIndex < audioClips.Count - 1)
        {
            trackIndex++;
            UpdateAudio();
            PlayAudio();
        }
        
    }


    public void PreviewTrack()
    {
        if (trackIndex >= 1)
        {
            trackIndex--;
            UpdateAudio();
            PlayAudio();
        }
        
    }


    public void AudioVolume(float volume)
    {
        audioSource.volume = volume;
    }


    public void TimeTrack(float time)
    {

        audioSource.time = time;

    }

    IEnumerator GetSound(string fileName)
    {
        UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip("file:///" + path, audioType: AudioType.MPEG);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {

            audioClips.Add(((DownloadHandlerAudioClip)www.downloadHandler).audioClip);
            audioClips[audioClips.Count - 1].name = fileName;
            



        }





    }

}