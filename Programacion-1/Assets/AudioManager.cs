using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;


    public void PlaySound(string soundName)
    {
        AudioClip sonido = FindSound(soundName);
        
        if (sonido != null)
        {
            audioSource.PlayOneShot(sonido);
        }
        else
        {
            Debug.LogError("No encontre el sonido:" + soundName);
        }
    }

    public AudioClip FindSound(string soundName)
    {
        AudioClip audioClip = null;

        foreach (AudioClip clip in audioClips)
        {
            if (clip.name == soundName)
            {
                return clip;
            }
        }

        return null;
    }
}
