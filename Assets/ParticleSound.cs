using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSound : MonoBehaviour
{
    private ParticleSystem Explosion;
    private int particleCount = 0;
    public AudioSource Sound;
    public int Soundlimiter;
    private float SoundTimer;

    void Start()
    {
        Explosion = this.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        SoundTimer += Time.deltaTime;
        if(particleCount < Explosion.particleCount/20 && particleCount < Soundlimiter && SoundTimer >= .2f)
        {
            Sound.Play(0);
            particleCount++;
        }else if(SoundTimer >= .2f)
        {
            particleCount -= 1;
            SoundTimer = 0;
        }
        Debug.Log("particle" + Explosion.particleCount);
        Debug.Log("Sound: " + particleCount);
    }
    
}
