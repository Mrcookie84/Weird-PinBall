using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum audioType
{
    Bounce,
    Destroyed,
    GameOver
}

public enum audioSourceType
{
    Game,
    Player
}

public class AudioManager : MonoBehaviour
{
    static public AudioManager instance;

    public float volume = 10f;

    public AudioSource gameSource;
    public AudioSource playerSource;
    
    [System.Serializable]
    public struct AudioData
    {
        public AudioClip clip;
        public audioType type;
    }

    public AudioData[] audioData;
    
    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameSource.volume = volume;
        playerSource.volume = volume;
    }

    public void PlaySound (audioType type, audioSourceType sourceType)
    {
        AudioClip clip = getClip(type);

        if (sourceType == audioSourceType.Game)
        {
            gameSource.PlayOneShot(clip);
        }
        else if (sourceType == audioSourceType.Player)
        {
            playerSource.PlayOneShot(clip);
        }
    }

    AudioClip getClip(audioType type)
    {
        foreach (AudioData data in audioData)
        {
            if (data.type == type)
            {
                return data.clip;
            }
        }
        Debug.LogError("AudioManager: No clip found for type " + type);
        return null;
    }
}

