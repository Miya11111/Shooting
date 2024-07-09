using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]
    public GameObject pause;
    public AudioClip m_start;

    AudioSource audioSource;

    public static bool CalledOnce;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape") && PlayerControl.GameoverOrNot == false)
        {
            if (!CalledOnce)
            {
                CalledOnce = true;
                audioSource.PlayOneShot(m_start);
            }
            Time.timeScale = 0;
            pause.gameObject.SetActive (true);
        }

        if (Input.GetKey("z"))
        {
            CalledOnce = false;
        }
    }
}
