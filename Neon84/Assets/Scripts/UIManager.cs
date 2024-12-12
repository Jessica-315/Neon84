using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public int idScene;

    // GameScene id: 1          MenuScene id: 0

    // HUDPanel:        0       MainPanel:      0
    // PausePanel:      1       PlayGamePanel:  1
    // GameOverPanel:   2       CreditsPanel:   2
    // Settings Panel:  3       SettingsPanel:  3

    public GameObject[] panelArray;


    
    public AudioMixer audioMixer;

    private float musicVolume;
    private float SFxVolume;


    // Start is called before the first frame update
    void Start()
    {
        ShowDefault();
    }

    // Se muestra HUDPanel o MainPanel
    public void ShowDefault()
    {
        CleanPanel();
        panelArray[0].SetActive(true);
    }

    public void ShowPause()
    {
        CleanPanel();
        panelArray[0].SetActive(true);
        panelArray[1].SetActive(true);
        Time.timeScale = 0;
        //AudioListener.pause = true;
        //audioMixer.SetFloat("SFxVolume", -80);
        //audioMixer.GetFloat
    }

    public void ShowPlayGame()
    {
        CleanPanel();
        panelArray[1].SetActive(true);
    }

    public void ShowGameOver()
    {
        CleanPanel();
        panelArray[2].SetActive(true);
    }

    public void ShowCredits()
    {
        CleanPanel();
        panelArray[2].SetActive(true);
    }

    public void ShowSettings()
    {
        CleanPanel();
        panelArray[3].SetActive(true);
    }

    public void ShowPlay()
    {
        ShowDefault();
        Time.timeScale = 1;
        //AudioListener.pause = false;
    }

    public void CleanPanel()
    {
        for (int i = 0; i < panelArray.Length; i++)
        {
            panelArray[i].SetActive(false);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void SetMusicVolume(float volume)
    {
        musicVolume = volume;
        audioMixer.SetFloat("MusicVolume", musicVolume);
    }

    public void SetSFxVolume(float volume)
    {
        SFxVolume = volume;
        audioMixer.SetFloat("SFxVolume", SFxVolume);
    }


}
