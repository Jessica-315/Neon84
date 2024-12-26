using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private float activate_pill = 0.2f;

    private float strike = 0.1f;
    private float shot = 0.15f;
    private float raw = 0.05f;
    


    public Slider healthSlider;
    public Slider waterSlider;
    public Slider foodSlider;


    //[SerializeField] private TimelineClip clip;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            healthSlider.value -= strike;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            healthSlider.value += activate_pill;
        }
    }
}
