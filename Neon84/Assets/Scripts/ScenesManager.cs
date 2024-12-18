using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    [SerializeField] private UIManager uimanager;


    [SerializeField] private AudioClip startSound;



    // GameScene id: 1          MenuScene id: 0

    // HUDPanel:        0       MainPanel:      0
    // PausePanel:      1       PlayGamePanel:  1
    // GameOverPanel:   2       CreditsPanel:   2
    //                          SettingsPanel:  3   


    public void LoadGameScene()
    {
        // Limpiar datos
        PlayerPrefs.SetInt("PanelPP", 0);
        SceneManager.LoadScene("GameScene");
        AudioManager.Instance.PlaySoundByName(startSound);
    }

    public void LoadMenuScene()
    {
        // Limpiar datos
        PlayerPrefs.SetInt("PanelPP", 0);
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadMenuSceneSettingsPanel()
    {
        // Guardar datos
        PlayerPrefs.SetInt("PanelPP", 2);
        SceneManager.LoadScene("MenuScene");
    }

    public void LoadGameSceneSettingsPanel()
    {
        // Guardar datos
        PlayerPrefs.SetInt("PanelPP", 2);
        SceneManager.LoadScene("GameScene");
    }

}
