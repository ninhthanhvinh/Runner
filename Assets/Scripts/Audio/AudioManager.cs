using UnityEngine;
using System;
using UnityEngine.SceneManagement;
//[System.Serializable]
//public class Sound
//{
//    public string name;
//    public AudioClip clip;

//    [Range(0f, 1f)]
//    public float volumn = .7f;
//    [Range(.5f, 1.5f)]
//    public float pitch = 1f;

//    [Range(0f, .5f)]
//    public float randomVolumn = .1f;
//    [Range(0f, .5f)]
//    public float randomPitch = .1f;

//    private AudioSource source;

//    public void SetSource(AudioSource _source)
//    {
//        source = _source;
//        source.clip = clip;
//    }

//    public void Play()
//    {
//        source.volume = volumn * (1 + Random.Range(-randomVolumn / 2f, randomVolumn / 2f));
//        source.pitch = pitch * (1 + Random.Range(-randomPitch / 2f, randomPitch / 2f));
//        source.Play();
//    }
//}

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField]
    Sound[] musics;
    [SerializeField]
    Sound[] sfxs;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musics, x => x.name == name);
        if (s == null)
            Debug.Log("Not found");
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxs, x => x.name == name);
        if (s == null)
            Debug.Log("Not found");
        else
        {
            sfxSource.clip = s.clip;
            sfxSource.Play();
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //void Start()
    //{
    //    for (int i = 0; i < sounds.Length; i++)
    //    {
    //        GameObject _go = new("Sound_" + i + "_" + sounds[i].name);
    //        _go.transform.SetParent(this.transform);
    //        sounds[i].SetSource(_go.AddComponent<AudioSource>());
    //    }
    //}

    //public void PlaySound(string _name)
    //{
    //    for (int i = 0; i < sounds.Length; i++)
    //    {
    //        if (sounds[i].name == _name)
    //        {
    //            sounds[i].Play();
    //            return;
    //        }
    //    }

    //    // no sound with _name
    //    Debug.LogWarning("Audio Manager: Sound not found");
}
