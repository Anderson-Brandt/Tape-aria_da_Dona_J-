using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControll : MonoBehaviour
{
    public AudioClip ButtonClick;
    public AudioClip CompleteRug;
    public AudioClip Tissue;

    public AudioClip BgMusic;

    [SerializeField] private AudioSource audioSource;

    private static AudioControll audioInstance;

    public static AudioControll current;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (audioInstance == null)
        {
            audioInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        current = this;
       
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void ChangeCompleteMscBGM()
    {
        audioSource.loop = false;
        audioSource.clip = CompleteRug;
        audioSource.Play();
    }

    public void ChangecloseCompletePainelMscBGM()
    {
        audioSource.loop = true;
        audioSource.clip = BgMusic;
        audioSource.Play();
    }

}
