using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip collectibleSound;
    
    public void playCollectibleSound()
    {
        
        source.PlayOneShot(collectibleSound);
        
    }
   
}
