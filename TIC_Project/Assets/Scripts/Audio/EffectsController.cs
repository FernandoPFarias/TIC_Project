using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsController : MonoBehaviour
{
    AudioSource audioSource;

    public AudioClip enemyDeathSound;
    public AudioClip egg;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    public void PlayEnemyDeath()
    {       
        audioSource.PlayOneShot(enemyDeathSound);
    }

    public void eggExplosion()
    {
        audioSource.PlayOneShot(egg);
    }
}
