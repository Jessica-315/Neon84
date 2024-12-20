using UnityEngine;

public class PlayerSFx : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] SFx;

    public void PlayEFx(int index)
    {
        audioSource.PlayOneShot(SFx[index]);
    }

    /*
    public Skybox skybox;

    public void ChangeSkybox()
    {
        skybox = GetComponent<Skybox>();
        skybox.material = 
    }
    */

}
