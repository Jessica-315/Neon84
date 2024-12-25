using UnityEngine;
using UnityEngine.Playables;

public class TimelinesController : MonoBehaviour
{
    public PlayableDirector director;

    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    public void PlayIntro()
    {
        director.Play();
    }

}
