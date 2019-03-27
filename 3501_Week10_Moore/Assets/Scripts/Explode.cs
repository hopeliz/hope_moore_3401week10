using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public ParticleSystem explosion;
    public Light glow;
    public GameObject treeToRemove;
    public GameObject treeToExplode;

    public int firesOut = 0;
    public float glowIntensity = 3;

    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<ParticleSystem>();
        glow = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (firesOut == 6)
        {
            explosion.Play();
            treeToRemove.SetActive(false);
            treeToExplode.SetActive(true);
        }

        if (!explosion.isPlaying)
        {
            glowIntensity -= glowIntensity * Time.deltaTime;
            glow.intensity = glowIntensity;
        }
    }
}
