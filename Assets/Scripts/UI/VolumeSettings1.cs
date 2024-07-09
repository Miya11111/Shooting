using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings1 : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audiomixer;


    // Start is called before the first frame update

    public void SetBGM(float volume)
    {
        audiomixer.SetFloat("BGMvol", volume);
    }

    public void SetSE(float volume)
    {
        audiomixer.SetFloat("SEvol", volume);
    }
}
