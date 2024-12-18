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
    //                          SettingsPanel:  3       

    public GameObject[] panelArray;


    // Estos sliders solo se referencian en la escena del menu principal (MenuScene)
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;




    // Start is called before the first frame update
    void Start()
    {

        ShowDefault();

        if (idScene == 0)
        {
            AudioManager.Instance.PlayMusic(0);
            musicSlider.value = AudioManager.Instance.GetMusicVolume();
            sfxSlider.value = AudioManager.Instance.GetSFxVolume();
            if (PlayerPrefs.GetInt("PanelPP") == 2)
            {
                ShowSettings();
            }
        }
        else
        {
            AudioManager.Instance.PlayMusic(1);
            if (PlayerPrefs.GetInt("PanelPP") == 2)
            {
                ShowPause();
            }
        }
        
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



    public void ChangeButtonExitSettings(ScenesManager scenesManager)
    {
        if (PlayerPrefs.GetInt("PanelPP") == 2)
        {
            scenesManager.LoadGameSceneSettingsPanel();
        }
        else
        {
            ShowDefault();
        }
    }


}
