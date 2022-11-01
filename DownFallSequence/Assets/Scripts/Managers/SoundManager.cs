using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip audiopukjjik;
    public AudioClip audiostone;
    public AudioClip audioruinsbgm;
    public AudioClip audiolennadie;
    public AudioClip audiointrohalfsad;
    public AudioClip audiointrohalfhappy;

    AudioSource audioSource;
    AudioSource audioSource2;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    //»ø∞˙¿Ω
    public void PlaySound(string action)
    {
        switch (action)
        {
            case "Pukjjik":
                audioSource.clip = audiopukjjik;
                break;
            case "Stone":
                audioSource.clip = audiostone;
                break;
        }
        audioSource.PlayOneShot(audioSource.clip);
    }

    //»ø∞˙¿Ω ∏ÿ√„
    public void StopSound(string action)
    {
        switch (action)
        {
            case "Pukjjik":
                audioSource.clip = audiopukjjik;
                break;
            case "Stone":
                audioSource.clip = audiostone;
                break;
            
        }
        audioSource.Stop();
    }

    //Bgm∏ÿ√„
    public void StopBgm(string action)
    {
        switch (action)
        {
            
            case "RuinsVillageBgm":
                audioSource2.clip = audioruinsbgm;
                break;
            case "LennaDie":
                audioSource2.clip = audiolennadie;
                break;
            case "IntroHalfSad":
                audioSource2.clip = audiointrohalfsad;
                break;
            case "IntroHalfHappy":
                audioSource2.clip = audiointrohalfhappy;
                break;
        }
        audioSource2.Stop();
    }

    //Bgm
    public void PlayBgm(string action)
    {
        switch (action)
        {
            
            case "RuinsVillageBgm":
                audioSource2.clip = audioruinsbgm;
                break;
            case "LennaDie":
                audioSource2.clip = audiolennadie;
                break;
            case "IntroHalfSad":
                audioSource2.clip = audiointrohalfsad;
                break;
            case "IntroHalfHappy":
                audioSource2.clip = audiointrohalfhappy;
                break;
        }
        audioSource2.PlayOneShot(audioSource2.clip);
    }
    
    
}
