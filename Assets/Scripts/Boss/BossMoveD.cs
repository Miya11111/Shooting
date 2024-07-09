using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveD : MonoBehaviour
{
    public float rotation;
    public float ifRandom;
    public float speed;
    public float rotateZ;
    public float destroy;
    public AudioClip m_fall;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(m_fall);
        Destroy(gameObject, destroy);
        Transform rotate = this.transform;
        Vector3 v3 = rotate.eulerAngles;
        v3.z = rotation + Random.value * 360 * ifRandom;
        rotate.eulerAngles = v3;

        StartCoroutine("A");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(0, 1 * speed, 0,Space.World);

    }

    IEnumerator A()
    {
        while (true)
        {
            Transform rotate = this.transform;
            Vector3 v3 = rotate.eulerAngles;
            v3.z += -1 * rotateZ;
            rotate.eulerAngles = v3;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
