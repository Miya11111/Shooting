using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMusic : MonoBehaviour
{
    public double TimeToAppear;
    public AudioClip m_boss;

    AudioSource audioSource;

    private float timer;
    bool CalledOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > TimeToAppear && !CalledOnce)
        {
            audioSource.PlayOneShot(m_boss);
            CalledOnce = true;
        }
    }
}
