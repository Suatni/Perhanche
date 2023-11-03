using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public AudioClip deathNoiseSound, dinoNoiseSound, hitNoiseSound, jumpNoiseSound, runNoiseSound;
    private AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlayDeathNoise()
    {
        audioSrc.PlayOneShot(deathNoiseSound);
    }

    public void PlayDinoNoises()
    {
        audioSrc.PlayOneShot(dinoNoiseSound);
    }

    public void PlayHitNoise()
    {
        audioSrc.PlayOneShot(hitNoiseSound);
    }

    public void PlayJumpNoise()
    {
        audioSrc.PlayOneShot(jumpNoiseSound);
    }

    public void PlayRunNoise()
    {
        audioSrc.PlayOneShot(runNoiseSound);
    }

    public void StopRunNoise()
    {
        audioSrc.Stop();
    }
}
