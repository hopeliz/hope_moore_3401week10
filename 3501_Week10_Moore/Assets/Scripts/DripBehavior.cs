using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DripBehavior : MonoBehaviour
{
    public ParticleSystem dripParticles;
    public Material splashMaterial;

    // Start is called before the first frame update
    void Start()
    {
        dripParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void OnParticleCollision(GameObject other)
    {
        dripParticles.GetComponent<Renderer>().material = splashMaterial;
        print("This works!");
    }

    public void Splash()
    {
        dripParticles.GetComponent<Renderer>().material = splashMaterial;
        print("This works!");
    }
    
}
