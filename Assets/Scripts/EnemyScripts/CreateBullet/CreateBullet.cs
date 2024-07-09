using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    public GameObject Bullet;
    public float Interval;
    public AudioClip m_shot;

    AudioSource audioSource;

    private void Start()
    {
        StartCoroutine("Create");
    }

     private IEnumerator Create()
    {
        while (true)
        {
            Instantiate(Bullet, this.transform.position,transform.rotation);
            audioSource = FindObjectOfType<AudioSource>();
            audioSource.PlayOneShot(m_shot);
            yield return new WaitForSeconds(Interval);
        }
    }
}
