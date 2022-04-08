using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSoundManager : MonoBehaviour
{
    public AudioClip backMusicNormal;
    public AudioClip backMusicDrama;

    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = gameObject.AddComponent<AudioSource>();
        _audioSource.loop = true;
        _audioSource.volume = 0.1f;
        _audioSource.clip = backMusicNormal;
        _audioSource.Play();
    }
}
