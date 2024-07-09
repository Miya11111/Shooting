using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSE : MonoBehaviour
{
    public AudioClip m_SE;
    AudioSource audioSource;

    private float count = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (Input.GetKey("right")  && count >= 0.1|| Input.GetKey("left") && count >= 0.1)
        {
            audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(m_SE);
            count = 0;
        }
    }
}
