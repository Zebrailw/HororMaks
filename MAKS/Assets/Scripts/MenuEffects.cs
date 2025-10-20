using UnityEngine;
using UnityEngine.UI;

public class MenuEffects : MonoBehaviour
{     
        
    
    
    public AudioSource staticAudioSource;
    public AudioClip staticSound;      
    
   
    
    private void Start()
    {
        SetupEffects();
    }
    
    private void SetupEffects()
    {
        
        if (staticAudioSource != null && staticSound != null)
        {
            staticAudioSource.clip = staticSound;
            staticAudioSource.loop = true;
            staticAudioSource.volume = 0.2f;
            staticAudioSource.Play();
        }
        
    }
  
    
    
    
   
    public void SetStaticVolume(float volume)
    {
        if (staticAudioSource != null)
        {
            staticAudioSource.volume = volume;
        }
    }
    
    public void EnableStaticNoise(bool enable)
    {
        
        if (staticAudioSource != null)
        {
            if (enable && !staticAudioSource.isPlaying)
            {
                staticAudioSource.Play();
            }
            else if (!enable && staticAudioSource.isPlaying)
            {
                staticAudioSource.Stop();
            }
        }
    }
    
    
    
}
