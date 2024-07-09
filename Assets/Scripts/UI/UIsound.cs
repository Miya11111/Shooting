using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIsound : MonoBehaviour
{
    public AudioClip m_start;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(m_start);

    }

    // Update is called once per frame
}
