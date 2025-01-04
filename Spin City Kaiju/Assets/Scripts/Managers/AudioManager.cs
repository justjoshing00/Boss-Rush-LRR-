using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
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

    public void PlaySFX()
    {

    }
    public void PlayBGM()
    {
       
    }
}
