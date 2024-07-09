using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSettings : MonoBehaviour
{
    Slider m_slider;
    public float SliderSpeed;
    public string n = "";
    void Awake()
    {
        m_slider = GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        float v = m_slider.value;
            if (Input.GetKey("left") && Input.GetKey(n))
            {
            v -= SliderSpeed;
            }
            if (Input.GetKey("right") && Input.GetKey(n))
            {
            v += SliderSpeed;
            }
        v = Mathf.Clamp(v, -40, 20);
        m_slider.value = v;
    }
}
