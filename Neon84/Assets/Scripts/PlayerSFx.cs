using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFx : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] SFx;

    public void PlayEFxAtaack()
    {
        audioSource.PlayOneShot(SFx[0]);
    }

}
