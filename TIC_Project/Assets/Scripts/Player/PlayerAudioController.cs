using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{   
    AudioSource audioSource;
    public AudioClip getItemSound;
    public AudioClip Damage;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }
    
    public void PlayGetItem()
    {
        audioSource.PlayOneShot(getItemSound);

        
    }
    public void Hurt()
    {
        audioSource.PlayOneShot(Damage);
    }
}
