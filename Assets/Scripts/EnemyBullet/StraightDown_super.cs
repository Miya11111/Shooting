using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightDown_super : MonoBehaviour
{
    public float speed;
    public float rotation;
    public float destroy;
    public AudioClip m_shot;

    AudioSource audioSource;
    private void Start()
    {
        Destroy(gameObject,destroy);

        Transform rotate = this.transform;
        Vector3 v3 = rotate.eulerAngles;
        v3.z = rotation;
        rotate.eulerAngles = v3;

        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(m_shot);
    }

    private void FixedUpdate()
    {
        this.transform.Translate(0, -0.05f * speed, 0);
    }
}
