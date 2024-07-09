using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warn : MonoBehaviour
{
    public float speed;
    public float n;
    public float destroy;
    public AudioClip m_warn;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(m_warn);
        StartCoroutine("A");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(-1 * speed, 0, 0);
        Destroy(gameObject, destroy);

    }

    private IEnumerator A()
    {
        yield return new WaitForSeconds(0.1f);

        for(int x = 1; x < 3; x++)
        {
            for (int i = 1; i < 10; i++)
            {
                Color color = gameObject.GetComponent<Renderer>().material.color;
                color.a -= n;
                gameObject.GetComponent<Renderer>().material.color = color;

                yield return new WaitForSeconds(0.1f);
            }

            yield return new WaitForSeconds(0.1f);

            for (int i = 1; i < 10; i++)
            {
                Color color = gameObject.GetComponent<Renderer>().material.color;
                color.a += n;
                gameObject.GetComponent<Renderer>().material.color = color;
                yield return new WaitForSeconds(0.3f);
            }
        }
    }
}
