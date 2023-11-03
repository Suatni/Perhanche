using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;
    private SoundManagerScript soundManager;

    // Adjust the delay values as needed
    public float hitNoiseDelay = 0.2f;
    public float deathNoiseDelay = 0.2f;
    public float respawnDelay = 0.5f;

    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManagerScript>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Play hit noise with a delay
            soundManager.PlayHitNoise();
            Invoke("PlayDeathNoiseWithDelay", hitNoiseDelay);
        }
    }

    // Custom function to play death noise with a delay
    void PlayDeathNoiseWithDelay()
    {
        soundManager.PlayDeathNoise();

        // Load the scene with a delay
        Invoke("LoadRespawnSceneWithDelay", deathNoiseDelay);
    }

    // Custom function to load the scene with a delay
    void LoadRespawnSceneWithDelay()
    {
        SceneManager.LoadScene(Respawn);
    }
}

