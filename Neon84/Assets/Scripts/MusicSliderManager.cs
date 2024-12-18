using UnityEngine;
using UnityEngine.UI;

public class MusicSliderManager : MonoBehaviour
{

    public Slider mySlider;


    void Start()
    {
        mySlider.onValueChanged.AddListener(AudioManager.Instance.SetMusicVolume);
    }

}
