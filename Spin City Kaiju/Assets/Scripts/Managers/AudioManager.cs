using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioSource> BGMs;
    public List<AudioSource> SFXs;

    public static AudioManager audioManagerInstance { get; private set; }
    private void Awake()
    {
        if (audioManagerInstance != null && audioManagerInstance != this)
        {
            Destroy(this);
        }
        else
        {
            audioManagerInstance = this;
        }
    }

    private void Start()
    {
        BGMs = new();
        SFXs = new();
    }

    public void PlaySFX()
    {

    }
    public void PlayBGM()
    {
       
    }
}
