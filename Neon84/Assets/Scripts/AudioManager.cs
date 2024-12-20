using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicAudioSource, sfxAudioSource;
    [SerializeField] private AudioClip[] musicClip, sfxClip;

    [SerializeField] public AudioMixer audioMixer;


    // [SerializeField] private Slider musicSlider;
    // [SerializeField] private Slider sfxSlider;

    private float musicVolume;
    private float SFxVolume;

    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
            PlayerPrefs.SetInt("PanelPP", 0);
        }
    }

    public void PlayMusic(int id)
    {
        musicAudioSource.clip = musicClip[id];
        musicAudioSource.Play();
    }

    public void PlaySoundByName(AudioClip clip)
    {
        sfxAudioSource.PlayOneShot(clip);
    }

    public void PlaySoundById(int id)
    {
        sfxAudioSource.PlayOneShot(sfxClip[id]);
    }

    public void SetMusicVolume(float volume)
    {
        musicVolume = volume;
        // Configura el volumen en el mixer
        audioMixer.SetFloat("MusicVolume", musicVolume);
        // Guardar datos en un Player prefab
        // PlayerPrefs.SetFloat("MusicVolumePP", musicVolume);
    }

    public void SetSFxVolume(float volume)
    {
        SFxVolume = volume;
        // Configura el volumen en el mixer
        audioMixer.SetFloat("SFxVolume", SFxVolume);
        // Guardar datos en un Player prefab
        // PlayerPrefs.SetFloat("SFxVolumePP", musicVolume);
    }

    public float GetMusicVolume()
    {
        // Recuperar datos
        //return PlayerPrefs.GetFloat("MusicVolumePP");
        float volume;
        audioMixer.GetFloat("MusicVolume", out volume);
        return volume;
    }

    public float GetSFxVolume()
    {
        // Recuperar datos
        //return PlayerPrefs.GetFloat("SFxVolumePP");
        float volume;
        audioMixer.GetFloat("SFxVolume", out volume);
        return volume;
    }


    /*
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
    }*/
}
