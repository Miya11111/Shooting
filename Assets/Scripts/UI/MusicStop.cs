using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStop : MonoBehaviour
{
    [SerializeField] public AudioSource a;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Pause.CalledOnce == true)
        {
            a.Pause();
        }

        if (Pause.CalledOnce == false)
        {
            a.UnPause();
        }
    }
}
