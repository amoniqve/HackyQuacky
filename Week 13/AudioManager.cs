using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [Header("Sources")]
    public AudioSource sfxSource;      
    public AudioSource oneShotSource;  

    [Header("Clips")]
    public AudioClip powerUpClip;
    public AudioClip powerDownClip;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        
        if (sfxSource == null) sfxSource = GetComponent<AudioSource>();
    }

    
    public void PlayOneShotClip(AudioClip clip, float volume = 1f)
    {
        if (clip == null) return;
        if (oneShotSource != null) oneShotSource.PlayOneShot(clip, volume);
        else if (sfxSource != null) sfxSource.PlayOneShot(clip, volume);
    }

    public void PlayPowerupSound()
    {
        PlayOneShotClip(powerUpClip);
    }

    public void PlayPowerdownSound()
    {
        PlayOneShotClip(powerDownClip);
    }

    public void PlayClip(AudioClip clip)
    {
        if (clip == null || sfxSource == null) return;
        sfxSource.clip = clip;
        sfxSource.Play();
    }
}
