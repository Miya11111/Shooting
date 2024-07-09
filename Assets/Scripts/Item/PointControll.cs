using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointControll : MonoBehaviour
{
    public float spread;
    public float destroy;
    public int n;
    public float fallspeed;
    public AudioClip m_destroy;

    AudioSource audioSource;

    private float randomspeed;
    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.PlayOneShot(m_destroy);

        Destroy(gameObject,destroy);
        randomspeed = spread;
        this.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f));
    }

    private void FixedUpdate()
    {
        this.transform.Translate(0, 0.01f * randomspeed, 0);
        randomspeed = randomspeed * (float)0.7;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(0, -2*fallspeed);
        rb.AddForce(force);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Player"))
        {
            PointCounter.point = PointCounter.point + n;
            gameObject.SetActive(false);
        }
    }
}
