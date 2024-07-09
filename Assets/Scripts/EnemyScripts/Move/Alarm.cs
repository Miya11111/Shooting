using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    public float destroy;
    public AudioClip m_alarm;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(m_alarm);
        Destroy(gameObject, destroy);
    }
        void Update()
    {
        
    }
}
