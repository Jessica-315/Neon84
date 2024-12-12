using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource musicAudioSource;
    public AudioClip[] musicClip;
    private int musicIndex;


    void Start()
    {
        musicIndex = 0;
        musicAudioSource.clip = musicClip[musicIndex];
        musicAudioSource.Play();
    }

    public void IncrementMusicLevel()
    {
        if(musicIndex < musicClip.Length - 1)
        {
            musicIndex++;
        }

        musicAudioSource.Stop();
        musicAudioSource.clip = musicClip[musicIndex];
        musicAudioSource.Play();
    }
}
