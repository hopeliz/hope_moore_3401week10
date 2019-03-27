using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehavior : MonoBehaviour
{
    public Explode explode;

    public ParticleSystem fireEffect;
    public Light lightGlow;

    public float fireCountdown = 3;
    public float lightFade = 2.30F;

    public bool fireballLanded = false;
    public bool fadeLight = false;

    // Start is called before the first frame update
    void Start()
    {
        fireEffect = GetComponent<ParticleSystem>();
        lightGlow = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fireballLanded)
        {
            fireCountdown -= fireCountdown * Time.deltaTime;
        }

        if (fireCountdown <= 1)
        {
            fireEffect.Stop();
            fadeLight = true;
        }

        if (fadeLight)
        {
            lightFade -= lightFade * Time.deltaTime;
            lightGlow.intensity = lightFade;
            explode.firesOut++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        fireballLanded = true;

    }
}
