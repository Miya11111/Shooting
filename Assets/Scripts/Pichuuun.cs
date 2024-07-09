using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pichuuun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var particleSystem = GetComponent<ParticleSystem>();
        Destroy(gameObject, particleSystem.main.duration);
    }
}
