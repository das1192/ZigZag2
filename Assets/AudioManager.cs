using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance;


    

    public Sound[] sounds;



     void Awake()
    {
        if (instance == null)
        {

            instance = this;

        }


        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;




        }




    }




    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }


    public void PlaySound(string name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Play();
    }


    public void StopSound(string name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.source.Stop();
    }


}
