using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    // 0 表示 全局的背景音乐
    //1 表示 球进了的声音
    //2 表示 球没进的声音
    //3 表示 脚与球相碰的声音
    public AudioClip[] GameSounds;

    private AudioSource _backgroundAudioSource;
    private AudioSource _effectAudioSource;

    void Start()
    {
        AudioSource [] AudioSourvces =  GetComponents<AudioSource>();
        _backgroundAudioSource = AudioSourvces[0];
        _effectAudioSource = AudioSourvces[1];
    }

    public void PlayBackgroundSound()
    {
        if (_backgroundAudioSource)
        {
            _backgroundAudioSource.loop = true;
            _backgroundAudioSource.volume = 0.4f;
            _backgroundAudioSource.clip = GameSounds[0];
            _backgroundAudioSource.Play();
        }
    }
    public void PlayShootSound()
    {
        Debug.Log("BBBB" + _effectAudioSource);
        if (_effectAudioSource)
        {
            Debug.Log("BBBB");
            _effectAudioSource.clip = GameSounds[3];
            _effectAudioSource.Play();
        }
    }
    public void PlayGoalSound()
    {
        if (_effectAudioSource)
        {
            _effectAudioSource.clip = GameSounds[1];
            _effectAudioSource.Play();
        }
    }
    public void PlayNoneGoadSound()
    {
        if (_effectAudioSource)
        {
            _effectAudioSource.clip = GameSounds[2];
            _effectAudioSource.Play();
        }
    }
}
