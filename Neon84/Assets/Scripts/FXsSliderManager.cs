using UnityEngine;
using UnityEngine.UI;

public class FXsSliderManager : MonoBehaviour
{

    public Slider mySlider;


    void Start()
    {
        mySlider.onValueChanged.AddListener(AudioManager.Instance.SetSFxVolume);
    }
}
