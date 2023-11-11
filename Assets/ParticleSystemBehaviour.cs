using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemBehaviour : MonoBehaviour
{
    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            particleSystem = GetComponent<ParticleSystem>();
            var emissionModule = particleSystem.velocityOverLifetime;
            emissionModule.x = 75;
            emissionModule.y = 0;
            particleSystem.Stop();
            particleSystem.Play();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            particleSystem = GetComponent<ParticleSystem>();
            var emissionModule = particleSystem.velocityOverLifetime;
            emissionModule.x = -75;
            emissionModule.y = 0;
            particleSystem.Stop();
            particleSystem.Play();

        }
    }
}
