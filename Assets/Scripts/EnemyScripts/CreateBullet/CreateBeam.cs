using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBeam : MonoBehaviour
{
    public GameObject PreBeam;
    public GameObject Beam;
    public float x1;
    public float y1;
    public float Interval;
    public int Count2 = 200;
    public int Count3 = 300;

    public AudioClip m_prebeam;
    public AudioClip m_beam;

    AudioSource audioSource;

    private int count;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }
    private void FixedUpdate()
    {
        count = count + 1;

        if(count == Count2)
        {
            Vector2 n = this.transform.position;
            n.x += x1;
            n.y += y1;
            Instantiate(PreBeam, n, transform.rotation);
            n.x -= x1 * 2;
            n.x += 0.2f;
            Instantiate(PreBeam, n, transform.rotation);
            audioSource.PlayOneShot(m_prebeam);
        }

        if (count == Count3)
        {
            audioSource.PlayOneShot(m_beam);
            StartCoroutine("Create");
        }
    }

    private IEnumerator Create()
    {
        while (true)
        {
            Vector2 n = this.transform.position;
            n.x += x1;
            n.y += y1;
            Instantiate(Beam, n, transform.rotation);
            n.x -= x1 * 2;
            n.x += 0.2f;
            Instantiate(Beam, n, transform.rotation);
            yield return new WaitForSeconds(Interval);
        }
    }
}
