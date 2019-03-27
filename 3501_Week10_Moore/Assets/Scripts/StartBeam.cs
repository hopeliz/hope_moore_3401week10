using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBeam : MonoBehaviour
{
    public ParticleSystem magicParticles;
    public GameObject spotlight;
    public int timesPlayed = 0;

    // Start is called before the first frame update
    void Start()
    {
        spotlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (magicParticles.isPlaying)
            {
                // Stop beam
                magicParticles.Stop();

                // Spotlight
                spotlight.SetActive(false);
            }
            else
            {
                // Spotlight
                spotlight.SetActive(true);

                // Start beam
                magicParticles.Play();
            }
        }
    }
}