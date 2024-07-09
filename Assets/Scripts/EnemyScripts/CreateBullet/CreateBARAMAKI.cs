using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBARAMAKI : MonoBehaviour
{
    public GameObject Bullet;
    public float Interval;
    public float FirstAngle;
    public float Angle;
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
            for(int i = 1;i <= 1; i++)
            {
                Instantiate(Bullet, transform.position, transform.rotation * Quaternion.Euler(0, 0, FirstAngle));
                audioSource = FindObjectOfType<AudioSource>();
                audioSource.PlayOneShot(m_shot);
                FirstAngle += Angle;
            }
            yield return new WaitForSeconds(Interval);
        }
    }
}
